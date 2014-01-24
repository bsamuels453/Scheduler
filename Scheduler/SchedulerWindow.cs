#region

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace Scheduler{
    public partial class SchedulerWindow : Form{
        const int _eventTableRowHeight = 22;
        readonly Dictionary<int, Tuple<string, DateTime>> _buttonToEventLookup;
        readonly Task _dailyReminderTask;
        readonly DataGridViewCellStyle _defaultStyle;
        readonly Scheduler _scheduler;

        readonly DataGridViewCellStyle _urgentStyle;
        readonly DataGridViewCellStyle _warningStyle;
        AddEvent _addEventForm;
        Task _fieldUpdateTask;
        bool _killFieldUpdateTask;

        public SchedulerWindow(){
            _warningsToDeploy = new List<DisplayEvent>();
            _deployedWarnings = new List<DisplayEvent>();
            _buttonToEventLookup = new Dictionary<int, Tuple<string, DateTime>>();
            _scheduler = new Scheduler();

            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            UpdateSchedulerTable(fieldEdited: true);
            UpdateCalendar();

            ClearEventDetails();

            _dailyReminderTask = new Task(DailyReminder);
            _dailyReminderTask.Start();


            _urgentStyle = new DataGridViewCellStyle();
            _urgentStyle.BackColor = Color.LightPink;
            _urgentStyle.SelectionBackColor = Color.LightPink;
            _warningStyle = new DataGridViewCellStyle();
            _warningStyle.BackColor = Color.LightYellow;
            _warningStyle.SelectionBackColor = Color.LightYellow;
            _defaultStyle = new DataGridViewCellStyle();
            _defaultStyle.BackColor = Color.LightGreen;
            _defaultStyle.SelectionBackColor = Color.LightGreen;
            EventTable.ClearSelection();
        }

        public void UpdateCalendar(){
            monthCalendar1.RemoveAllBoldedDates();
            var events = _scheduler.GetActiveEvents();
            foreach (DisplayEvent t in events){
                monthCalendar1.AddBoldedDate(t.EventDateTime);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldEdited">whether or not any of the non-time fields may have changed.</param>
        public void UpdateSchedulerTable(bool fieldEdited){
            int numPrevEvents = EventTable.RowCount;
            _scheduler.RefreshActiveEvents();
            var events = _scheduler.GetActiveEvents();
            var sorted = events.OrderBy(e => e.EventDateTime).ToArray();
            EventTable.RowCount = sorted.Length;
            for (int i = 0; i < sorted.Length; i++){
                var daysRemaining = (sorted[i].EventDateTime - DateTime.Now).Days;

                if (daysRemaining >= 7){
                    EventTable[0, i].Style = _defaultStyle;
                    EventTable[1, i].Style = _defaultStyle;
                    EventTable[2, i].Style = _defaultStyle;
                    EventTable[3, i].Style = _defaultStyle;
                }
                if (daysRemaining < 7 && daysRemaining >= 1){
                    EventTable[0, i].Style = _warningStyle;
                    EventTable[1, i].Style = _warningStyle;
                    EventTable[2, i].Style = _warningStyle;
                    EventTable[3, i].Style = _warningStyle;
                }
                if (daysRemaining < 1){
                    EventTable[0, i].Style = _urgentStyle;
                    EventTable[1, i].Style = _urgentStyle;
                    EventTable[2, i].Style = _urgentStyle;
                    EventTable[3, i].Style = _urgentStyle;
                }

                EventTable[0, i].Value = sorted[i].Description;
                EventTable[1, i].Value = sorted[i].Date;
                EventTable[2, i].Value = sorted[i].Time;
                EventTable[3, i].Value = sorted[i].TimeUntil;
            }
            if (fieldEdited){
                ClearEventDetails();
                EventTable.ClearSelection();
                EventTable.Height = EventTable.RowCount*_eventTableRowHeight;
                _buttonToEventLookup.Clear();
                for (int i = 0; i < sorted.Length; i++){
                    EventTable[0, i].Tag = i;
                    _buttonToEventLookup.Add(i, new Tuple<string, DateTime>(sorted[i].Description, sorted[i].EventDateTime));
                }
            }
        }

        void UpdateFieldsLoop(){
            while (true){
                Thread.Sleep(50);
                if (_killFieldUpdateTask){
                    break;
                }
                this.BeginInvoke((Action) (() => UpdateSchedulerTable(fieldEdited: false)));
            }
        }

        void EventTableCellClick(object sender, DataGridViewCellEventArgs e){
            var selectedCells = EventTable.SelectedCells;
            var tag = (int) selectedCells[0].Tag;
            var details = _buttonToEventLookup[tag];
            var description = details.Item1;
            var datetime = details.Item2;
            EditDescription.Text = description;
            EditDatePicker.Value = datetime;
            EditTimePicker.Value = datetime;
            EditDatePicker.MinDate = DateTime.Now;
            EditTimePicker.MinDate = DateTime.Now;
            EnableEventDetailFields();
            DisableEditFields();
        }

        void EnableEventDetailFields(){
            EditDescription.Visible = true;
            EditDatePicker.Visible = true;
            EditTimePicker.Visible = true;
            EditEventButton.Visible = true;
            RemoveEventButton.Visible = true;
            EditEventButton.Enabled = true;
            RemoveEventButton.Enabled = true;
        }

        void DisableEventDetailFields(){
            RemoveEventButton.Enabled = false;
            EditEventButton.Enabled = false;
            EditDescription.Visible = false;
            EditDatePicker.Visible = false;
            EditTimePicker.Visible = false;
            EditEventButton.Visible = false;
            RemoveEventButton.Visible = false;
        }

        void EnableEditFields(){
            EditEventButton.Visible = false;
            CancelEditButton.Visible = true;
            SaveChangesButton.Visible = true;
            RemoveEventButton.Enabled = false;
            EditDatePicker.Enabled = true;
            EditTimePicker.Enabled = true;
            EditDescription.Enabled = true;
        }

        void DisableEditFields(){
            EditEventButton.Visible = true;
            CancelEditButton.Visible = false;
            SaveChangesButton.Visible = false;
            RemoveEventButton.Enabled = true;
            EditDatePicker.Enabled = false;
            EditTimePicker.Enabled = false;
            EditDescription.Enabled = false;
        }

        void ClearEventDetails(){
            EditDescription.Text = "";
            DisableEditFields();
            DisableEventDetailFields();
        }

        void EditEventButtonClick(object sender, EventArgs e){
            EnableEditFields();
        }

        void RemoveEventButtonClick(object sender, EventArgs e){
            var eventDescr = EditDescription.Text;
            var eventDate = EditDatePicker.Value;
            var result = MessageBox.Show("Do you REALLY want to cancel " + eventDescr + "?!", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes){
                _scheduler.CancelEvent(eventDescr, eventDate);
                UpdateSchedulerTable(fieldEdited: true);
                UpdateCalendar();
                EventTable.ClearSelection();
                ClearEventDetails();
            }
        }

        void SaveChangesButtonClick(object sender, EventArgs e){
            var date = EditDatePicker.Value;
            var time = EditTimePicker.Value;
            var newDescr = EditDescription.Text;

            var eventDatetime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            if (eventDatetime < DateTime.Now){
                MessageBox.Show("You need to select a date and time that is in the future");
                return;
            }
            var tag = (int) EventTable.SelectedCells[0].Tag;
            var origDescr = _buttonToEventLookup[tag].Item1;
            var origTime = _buttonToEventLookup[tag].Item2;
            _scheduler.EditEvent(origDescr, origTime, newDescr, eventDatetime);
            DisableEditFields();
            UpdateSchedulerTable(fieldEdited: true);
            UpdateCalendar();
        }

        void CancelEditButtonClick(object sender, EventArgs e){
            var tag = (int) EventTable.SelectedCells[0].Tag;
            var eventData = _buttonToEventLookup[tag];
            EditDescription.Text = eventData.Item1;
            EditDatePicker.Value = eventData.Item2;
            EditTimePicker.Value = eventData.Item2;
            DisableEditFields();
        }

        #region window/notifyicon stuff

        void SchedulerWindowActivated(object sender, EventArgs e){
            _fieldUpdateTask = new Task(UpdateFieldsLoop);
            _killFieldUpdateTask = false;
            _fieldUpdateTask.Start();
        }

        void SchedulerWindowDeactivate(object sender, EventArgs e){
            _killFieldUpdateTask = true;
            _fieldUpdateTask.Wait();
        }

        void SchedulerWindowFormClosing(object sender, FormClosingEventArgs e){
            _killFieldUpdateTask = true;
            _fieldUpdateTask.Wait();
            NotifyIcon.Icon = null;
        }

        void NotifyIcon1DoubleClick(object sender, EventArgs e){
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
            EventTable.ClearSelection();
            ClearEventDetails();
            UpdateSchedulerTable(fieldEdited: false);
            UpdateCalendar();
        }

        void NotifyIcon1MouseDoubleClick(object sender, MouseEventArgs e){
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
            EventTable.ClearSelection();
            ClearEventDetails();
            UpdateSchedulerTable(fieldEdited: false);
            UpdateCalendar();
        }

        void SchedulerWindowResize(object sender, EventArgs e){
            if (FormWindowState.Minimized == this.WindowState){
                NotifyIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState){
                NotifyIcon.Visible = false;
                EventTable.ClearSelection();
                ClearEventDetails();
                UpdateSchedulerTable(fieldEdited: false);
                UpdateCalendar();
            }
        }

        void NotifyIconMouseClick(object sender, MouseEventArgs e){
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
            EventTable.ClearSelection();
            ClearEventDetails();
            UpdateSchedulerTable(fieldEdited: false);
            UpdateCalendar();
        }

        void EventPanelClick(object sender, EventArgs e){
            EventTable.ClearSelection();
            ClearEventDetails();
        }

        void SchedulerWindowClick(object sender, EventArgs e){
            EventTable.ClearSelection();
            ClearEventDetails();
        }

        void MenuStrip1Click(object sender, EventArgs e){
            EventTable.ClearSelection();
            ClearEventDetails();
        }

        #endregion

        #region main ui delegs

        void AddEventToolStripMenuItemClick(object sender, EventArgs e){
            _addEventForm = new AddEvent(_scheduler, this);
        }

        #endregion
    }
}
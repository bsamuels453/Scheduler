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
        const string _editButtonText = "Edit";
        const string _removeButtonText = "Remove";
        const int _eventTableRowHeight = 22;
        readonly Dictionary<int, Tuple<string, DateTime>> _buttonToEventLookup;
        readonly Task _dailyReminderTask;
        readonly DataGridViewCellStyle _defaultStyle;
        readonly Point _editButtonBase = new Point(457, 19);
        readonly List<Button> _editButtons;
        readonly Size _editButtonsize = new Size(35, 19);
        readonly Point _removeButtonBase = new Point(491, 19);
        readonly List<Button> _removeButtons;
        readonly Size _removeButtonsize = new Size(55, 19);
        readonly Scheduler _scheduler;

        readonly DataGridViewCellStyle _urgentStyle;
        readonly DataGridViewCellStyle _warningStyle;
        AddEvent _addEventForm;
        Task _fieldUpdateTask;
        bool _killFieldUpdateTask;

        public SchedulerWindow(){
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _warningsToDeploy = new List<DisplayEvent>();
            _deployedWarnings = new List<DisplayEvent>();
            _editButtons = new List<Button>();
            _removeButtons = new List<Button>();
            _buttonToEventLookup = new Dictionary<int, Tuple<string, DateTime>>();
            _scheduler = new Scheduler();
            UpdateSchedulerTable();
            UpdateCalendar();
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
        }

        public void UpdateCalendar(){
            monthCalendar1.RemoveAllBoldedDates();
            var events = _scheduler.GetActiveEvents();
            foreach (DisplayEvent t in events){
                monthCalendar1.AddBoldedDate(t.EventDateTime);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        public void UpdateSchedulerTable(){
            int numPrevEvents = EventTable.RowCount;
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
            if (numPrevEvents != EventTable.RowCount){
                EventTable.Height = 30 + EventTable.RowCount*_eventTableRowHeight;
                UpdateSchedulerTableButtons(sorted);
            }
        }

        void UpdateSchedulerTableButtons(DisplayEvent[] displayedEvents){
            foreach (var button in _editButtons){
                button.Dispose();
            }
            foreach (var button in _removeButtons){
                button.Dispose();
            }
            _editButtons.Clear();
            _removeButtons.Clear();
            _buttonToEventLookup.Clear();

            for (int i = 0; i < EventTable.RowCount; i++){
                var editButton = new Button();
                editButton.Parent = EventPanel;
                editButton.Location = new Point(_editButtonBase.X, _editButtonBase.Y + _eventTableRowHeight*i);
                editButton.Size = _editButtonsize;
                editButton.Text = _editButtonText;
                editButton.Name = i.ToString();
                editButton.Click += OnEditButtonClicked;
                editButton.Enabled = false;
                _editButtons.Add(editButton);

                var removeButton = new Button();
                removeButton.Parent = EventPanel;
                removeButton.Location = new Point(_removeButtonBase.X, _removeButtonBase.Y + _eventTableRowHeight*i);
                removeButton.Size = _removeButtonsize;
                removeButton.Text = _removeButtonText;
                removeButton.Name = i.ToString();
                removeButton.Click += OnCancelButtonClicked;
                _removeButtons.Add(removeButton);

                _buttonToEventLookup.Add
                    (
                        i,
                        new Tuple<string, DateTime>
                            (
                            displayedEvents[i].Description,
                            displayedEvents[i].EventDateTime
                            ));
            }
        }

        void UpdateFieldsLoop(){
            while (true){
                Thread.Sleep(50);
                if (_killFieldUpdateTask){
                    break;
                }
                this.BeginInvoke((Action) UpdateSchedulerTable);
            }
        }

        #region main ui delegs

        void AddEventToolStripMenuItemClick(object sender, EventArgs e){
            _addEventForm = new AddEvent(_scheduler, this);
        }

        void OnCancelButtonClicked(object sender, EventArgs e){
            var eventId = int.Parse(((Button) sender).Name);
            var eventDescr = _buttonToEventLookup[eventId].Item1;
            var eventDate = _buttonToEventLookup[eventId].Item2;
            var result = MessageBox.Show("Do you REALLY want to cancel " + eventDescr + "?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes){
                _scheduler.CancelEvent(eventDescr, eventDate);
                UpdateSchedulerTable();
                UpdateCalendar();
            }
        }

        void OnEditButtonClicked(object sender, EventArgs e){
        }

        /*
        void CancelButtonClick(object sender, EventArgs e){
            var eventToCancel = CancellationComboBox.Text;
            _scheduler.CancelEvent(eventToCancel);
            ResetEventCancelFields();
            UpdateSchedulerTable();
            UpdateCalendar();
        }

        void CancellationComboBoxMouseDown(object sender, MouseEventArgs _){
            var events = _scheduler.GetActiveEvents();
            var eventNames = events.Select(e => e.Description).ToList();
            eventNames.Insert(0, "");
            CancellationComboBox.DataSource = eventNames;
        }

        void CancellationComboBoxSelectionChangeCommitted(object sender, EventArgs e){
            UpdateSchedulerTable();
            if (CancellationComboBox.Text == ""){
                CancButton.Enabled = false;
            }
            else{
                CancButton.Enabled = true;
            }
        }
         */

        #endregion

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
        }

        void NotifyIcon1MouseDoubleClick(object sender, MouseEventArgs e){
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        void SchedulerWindowResize(object sender, EventArgs e){
            if (FormWindowState.Minimized == this.WindowState){
                NotifyIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState){
                NotifyIcon.Visible = false;
                //Application.OpenForms["PikaForm"].BringToFront();
            }
        }

        void NotifyIconMouseClick(object sender, MouseEventArgs e){
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        #endregion
    }
}
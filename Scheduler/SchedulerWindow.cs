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
        readonly Task _dailyReminderTask;
        readonly DataGridViewCellStyle _defaultStyle;
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
            _scheduler = new Scheduler();
            UpdateSchedulerTable();
            UpdateCalendar();
            ResetEventCancelFields();
            _dailyReminderTask = new Task(DailyReminder);
            _dailyReminderTask.Start();
            _warningsToDeploy = new List<DisplayEvent>();
            _deployedWarnings = new List<DisplayEvent>();

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

        void ResetEventCancelFields(){
            CancellationComboBox.DataSource = null;
            CancellationComboBox.SelectedIndex = -1;
            CancButton.Enabled = false;
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

        void AddEventToolStripMenuItemClick(object sender, EventArgs e){
            _addEventForm = new AddEvent(_scheduler, this);
        }

        #region main ui delegs

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
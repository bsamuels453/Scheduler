#region

using System;
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
        Task _fieldUpdateTask;
        bool _killFieldUpdateTask;

        public SchedulerWindow(){
            InitializeComponent();
            _scheduler = new Scheduler();
            UpdateSchedulerTable();
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

        void DailyReminder(){
            while (true){
                Thread.Sleep(1000);
                var events = _scheduler.GetRawActiveEvents();
                bool upcomingEventDetected = false;
                foreach (var @event in events){
                    if (@event.EventDate - DateTime.Now < new TimeSpan(1, 0, 0, 0)){
                        upcomingEventDetected = true;
                        break;
                    }
                }

                if (upcomingEventDetected){
                    NotifyIcon.Icon = new Icon("redwarn.ico");
                }
                else{
                    NotifyIcon.Icon = new Icon("happyface.ico");
                }
            }
        }

        void CancelButton_Click(object sender, EventArgs e){
            var eventToCancel = CancellationComboBox.Text;
            _scheduler.CancelEvent(eventToCancel);
            ResetEventCancelFields();
            UpdateSchedulerTable();
        }

        void AddEventButton_Click(object sender, EventArgs e){
            var date = NewEventDatePicker.Value;
            var time = NewEventTimePicker.Value;

            var eventDatetime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);

            _scheduler.AddEvent(DescriptionTextBox.Text, eventDatetime);

            ResetEventAdditionFields();
            UpdateSchedulerTable();
        }

        void ResetEventCancelFields(){
            CancellationComboBox.DataSource = null;
            CancellationComboBox.SelectedIndex = -1;
            CancButton.Enabled = false;
        }

        void ResetEventAdditionFields(){
            DescriptionTextBox.Text = "Description...";
            NewEventDatePicker.Value = DateTime.Now;
            NewEventTimePicker.Value = DateTime.Now;
            AddEventButton.Enabled = false;
        }

        void CancellationComboBox_MouseDown(object sender, MouseEventArgs _){
            var events = _scheduler.GetActiveEvents();
            var eventNames = events.Select(e => e.Description).ToList();
            eventNames.Insert(0, "");
            CancellationComboBox.DataSource = eventNames;
        }

        void DescriptionTextBox_MouseDown(object sender, MouseEventArgs e){
            if (DescriptionTextBox.Text.Equals("Description...")){
                DescriptionTextBox.Text = "";
            }
        }

        void CancellationComboBox_SelectionChangeCommitted(object sender, EventArgs e){
            UpdateSchedulerTable();
            if (CancellationComboBox.Text == ""){
                CancButton.Enabled = false;
            }
            else{
                CancButton.Enabled = true;
            }
        }

        void DescriptionTextBox_TextChanged(object sender, EventArgs e){
            if (!DescriptionTextBox.Text.Equals("Description...") && !DescriptionTextBox.Text.Equals("")){
                AddEventButton.Enabled = true;
            }
            else{
                AddEventButton.Enabled = false;
            }
        }

        void UpdateSchedulerTable(){
            monthCalendar1.RemoveAllBoldedDates();
            var events = _scheduler.GetActiveEvents();
            var sorted = events.OrderBy(e => e.Date).ToArray();
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
                monthCalendar1.AddBoldedDate(sorted[i].EventDateTime);
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


        void SchedulerWindow_Activated(object sender, EventArgs e){
            _fieldUpdateTask = new Task(UpdateFieldsLoop);
            _killFieldUpdateTask = false;
            _fieldUpdateTask.Start();
        }

        void SchedulerWindow_Deactivate(object sender, EventArgs e){
            _killFieldUpdateTask = true;
            _fieldUpdateTask.Wait();
        }

        void SchedulerWindow_FormClosing(object sender, FormClosingEventArgs e){
            _killFieldUpdateTask = true;
            _fieldUpdateTask.Wait();
        }

        void notifyIcon1_DoubleClick(object sender, EventArgs e){
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e){
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        void SchedulerWindow_Resize(object sender, EventArgs e){
            if (FormWindowState.Minimized == this.WindowState){
                NotifyIcon.Visible = true;
                NotifyIcon.ShowBalloonTip(2);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState){
                NotifyIcon.Visible = false;
                //Application.OpenForms["PikaForm"].BringToFront();
            }
        }

        void NotifyIcon_MouseClick(object sender, MouseEventArgs e){
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }
    }
}
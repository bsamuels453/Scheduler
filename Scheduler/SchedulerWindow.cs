#region

using System;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace Scheduler{
    public partial class SchedulerWindow : Form{
        readonly Scheduler _scheduler;

        public SchedulerWindow(){
            InitializeComponent();
            _scheduler = new Scheduler();
            UpdateSchedulerTable();
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
            DescriptionTextBox.Text = "Description goes here";
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
            if (DescriptionTextBox.Text.Equals("Description goes here")){
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
            if (!DescriptionTextBox.Text.Equals("Description goes here") && !DescriptionTextBox.Text.Equals("")){
                AddEventButton.Enabled = true;
            }
            else{
                AddEventButton.Enabled = false;
            }
        }

        void UpdateSchedulerTable(){
            var events = _scheduler.GetActiveEvents();
            var sorted = events.OrderBy(e => e.Date).ToArray();
            EventTable.RowCount = sorted.Length;
            for (int i = 0; i < sorted.Length; i++){
                EventTable[0, i].Value = sorted[i].Description;
                EventTable[1, i].Value = sorted[i].Date;
                EventTable[2, i].Value = sorted[i].Time;
                EventTable[3, i].Value = sorted[i].TimeUntil;
            }
        }
    }
}
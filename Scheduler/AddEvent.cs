#region

using System;
using System.Windows.Forms;

#endregion

namespace Scheduler{
    public partial class AddEvent : Form{
        const string _enterDescription = "Enter description...";
        const string _enterFutureDate = "You need to select a date and time that is in the future";

        readonly Scheduler _scheduler;
        readonly SchedulerWindow _schedulerForm;

        public AddEvent(Scheduler scheduler, SchedulerWindow schedulerForm){
            InitializeComponent();
            _scheduler = scheduler;
            _schedulerForm = schedulerForm;
            DescriptionTextBox.Text = _enterDescription;
            NewEventDatePicker.MinDate = DateTime.Now;
            NewEventTimePicker.MinDate = DateTime.Now;

            this.ShowDialog();
        }

        void AddEventButtonClicked(object sender, EventArgs e){
            var date = NewEventDatePicker.Value;
            var time = NewEventTimePicker.Value;

            var eventDatetime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            if (eventDatetime < DateTime.Now){
                MessageBox.Show(_enterFutureDate);
                return;
            }
            _scheduler.AddEvent(DescriptionTextBox.Text, eventDatetime);
            _schedulerForm.Invoke(new Action(() => _schedulerForm.UpdateSchedulerTable(fieldEdited: true)));
            _schedulerForm.Invoke(new Action(_schedulerForm.UpdateCalendar));
            this.Close();
        }

        void DescriptionTextBoxMouseDown(object sender, MouseEventArgs e){
            if (DescriptionTextBox.Text.Equals(_enterDescription)){
                DescriptionTextBox.Text = "";
            }
        }

        void DescriptionTextBoxTextChanged(object sender, EventArgs e){
            if (!DescriptionTextBox.Text.Equals(_enterDescription) && !DescriptionTextBox.Text.Equals("")){
                AddEventButton.Enabled = true;
            }
            else{
                AddEventButton.Enabled = false;
            }
        }
    }
}
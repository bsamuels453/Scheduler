namespace Scheduler {
    partial class AddEvent {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NewEventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NewEventTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 12);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(300, 20);
            this.DescriptionTextBox.TabIndex = 0;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBoxTextChanged);
            this.DescriptionTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DescriptionTextBoxMouseDown);
            // 
            // NewEventDatePicker
            // 
            this.NewEventDatePicker.Location = new System.Drawing.Point(12, 38);
            this.NewEventDatePicker.Name = "NewEventDatePicker";
            this.NewEventDatePicker.Size = new System.Drawing.Size(200, 20);
            this.NewEventDatePicker.TabIndex = 1;
            // 
            // NewEventTimePicker
            // 
            this.NewEventTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.NewEventTimePicker.Location = new System.Drawing.Point(218, 38);
            this.NewEventTimePicker.Name = "NewEventTimePicker";
            this.NewEventTimePicker.ShowUpDown = true;
            this.NewEventTimePicker.Size = new System.Drawing.Size(94, 20);
            this.NewEventTimePicker.TabIndex = 2;
            // 
            // AddEventButton
            // 
            this.AddEventButton.Location = new System.Drawing.Point(237, 64);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(75, 23);
            this.AddEventButton.TabIndex = 3;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButtonClicked);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 100);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.NewEventTimePicker);
            this.Controls.Add(this.NewEventDatePicker);
            this.Controls.Add(this.DescriptionTextBox);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.DateTimePicker NewEventDatePicker;
        private System.Windows.Forms.DateTimePicker NewEventTimePicker;
        private System.Windows.Forms.Button AddEventButton;
    }
}
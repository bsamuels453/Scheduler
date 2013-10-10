namespace Scheduler {
    partial class SchedulerWindow {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EventTable = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CancellationComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EventTable
            // 
            this.EventTable.AllowUserToAddRows = false;
            this.EventTable.AllowUserToDeleteRows = false;
            this.EventTable.AllowUserToResizeColumns = false;
            this.EventTable.AllowUserToResizeRows = false;
            this.EventTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EventTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventTable.ColumnHeadersVisible = false;
            this.EventTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.DateAt,
            this.TimeAt,
            this.TimeUntil});
            this.EventTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.EventTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventTable.Location = new System.Drawing.Point(18, 206);
            this.EventTable.Name = "EventTable";
            this.EventTable.RowHeadersVisible = false;
            this.EventTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EventTable.Size = new System.Drawing.Size(471, 186);
            this.EventTable.TabIndex = 3;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Column1";
            this.Description.MinimumWidth = 250;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DateAt
            // 
            this.DateAt.HeaderText = "Column1";
            this.DateAt.MinimumWidth = 70;
            this.DateAt.Name = "DateAt";
            this.DateAt.ReadOnly = true;
            this.DateAt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAt.Width = 70;
            // 
            // TimeAt
            // 
            this.TimeAt.HeaderText = "Column1";
            this.TimeAt.MinimumWidth = 60;
            this.TimeAt.Name = "TimeAt";
            this.TimeAt.ReadOnly = true;
            this.TimeAt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeAt.Width = 60;
            // 
            // TimeUntil
            // 
            this.TimeUntil.HeaderText = "Column1";
            this.TimeUntil.MinimumWidth = 70;
            this.TimeUntil.Name = "TimeUntil";
            this.TimeUntil.ReadOnly = true;
            this.TimeUntil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeUntil.Width = 70;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TimeUntil";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 447);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add Event";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Description";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(224, 447);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // AddEventButton
            // 
            this.AddEventButton.Location = new System.Drawing.Point(326, 444);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(75, 23);
            this.AddEventButton.TabIndex = 14;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cancel Event";
            // 
            // CancellationComboBox
            // 
            this.CancellationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CancellationComboBox.FormattingEnabled = true;
            this.CancellationComboBox.Location = new System.Drawing.Point(18, 498);
            this.CancellationComboBox.Name = "CancellationComboBox";
            this.CancellationComboBox.Size = new System.Drawing.Size(200, 21);
            this.CancellationComboBox.TabIndex = 16;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(18, 525);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SchedulerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CancellationComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.EventTable);
            this.Name = "SchedulerWindow";
            this.Text = "Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EventTable;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CancellationComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeUntil;
    }
}


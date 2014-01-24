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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventPanel = new System.Windows.Forms.Panel();
            this.EventTable = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelEditButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.EditTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RemoveEventButton = new System.Windows.Forms.Button();
            this.EditDescription = new System.Windows.Forms.TextBox();
            this.EditEventButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.EventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Scheduler";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon1DoubleClick);
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconMouseClick);
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.MenuStrip1Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.exportEventsToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.AddEventToolStripMenuItemClick);
            // 
            // exportEventsToolStripMenuItem
            // 
            this.exportEventsToolStripMenuItem.Enabled = false;
            this.exportEventsToolStripMenuItem.Name = "exportEventsToolStripMenuItem";
            this.exportEventsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exportEventsToolStripMenuItem.Text = "Export Events";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // EventPanel
            // 
            this.EventPanel.AutoScroll = true;
            this.EventPanel.Controls.Add(this.EventTable);
            this.EventPanel.Location = new System.Drawing.Point(17, 199);
            this.EventPanel.Name = "EventPanel";
            this.EventPanel.Size = new System.Drawing.Size(581, 362);
            this.EventPanel.TabIndex = 20;
            this.EventPanel.Click += new System.EventHandler(this.EventPanelClick);
            // 
            // EventTable
            // 
            this.EventTable.AllowUserToAddRows = false;
            this.EventTable.AllowUserToDeleteRows = false;
            this.EventTable.AllowUserToResizeColumns = false;
            this.EventTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.EventTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.EventTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EventTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.EventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventTable.ColumnHeadersVisible = false;
            this.EventTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.DateAt,
            this.TimeAt,
            this.TimeUntil});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EventTable.DefaultCellStyle = dataGridViewCellStyle27;
            this.EventTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EventTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventTable.Location = new System.Drawing.Point(2, 0);
            this.EventTable.MultiSelect = false;
            this.EventTable.Name = "EventTable";
            this.EventTable.ReadOnly = true;
            this.EventTable.RowHeadersVisible = false;
            this.EventTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.EventTable.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.EventTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EventTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventTable.Size = new System.Drawing.Size(561, 293);
            this.EventTable.TabIndex = 4;
            this.EventTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventTableCellClick);
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 220;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateAt
            // 
            this.DateAt.HeaderText = "Date";
            this.DateAt.MinimumWidth = 70;
            this.DateAt.Name = "DateAt";
            this.DateAt.ReadOnly = true;
            this.DateAt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateAt.Width = 70;
            // 
            // TimeAt
            // 
            this.TimeAt.HeaderText = "Time";
            this.TimeAt.MinimumWidth = 60;
            this.TimeAt.Name = "TimeAt";
            this.TimeAt.ReadOnly = true;
            this.TimeAt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TimeAt.Width = 60;
            // 
            // TimeUntil
            // 
            this.TimeUntil.HeaderText = "TimeUntil";
            this.TimeUntil.MinimumWidth = 90;
            this.TimeUntil.Name = "TimeUntil";
            this.TimeUntil.ReadOnly = true;
            this.TimeUntil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeUntil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TimeUntil.Width = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelEditButton);
            this.groupBox1.Controls.Add(this.SaveChangesButton);
            this.groupBox1.Controls.Add(this.EditTimePicker);
            this.groupBox1.Controls.Add(this.EditDatePicker);
            this.groupBox1.Controls.Add(this.RemoveEventButton);
            this.groupBox1.Controls.Add(this.EditDescription);
            this.groupBox1.Controls.Add(this.EditEventButton);
            this.groupBox1.Location = new System.Drawing.Point(253, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 128);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.Location = new System.Drawing.Point(156, 95);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.Size = new System.Drawing.Size(75, 23);
            this.CancelEditButton.TabIndex = 6;
            this.CancelEditButton.Text = "Cancel Edit";
            this.CancelEditButton.UseVisualStyleBackColor = true;
            this.CancelEditButton.Visible = false;
            this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButtonClick);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(65, 95);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(85, 23);
            this.SaveChangesButton.TabIndex = 5;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Visible = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButtonClick);
            // 
            // EditTimePicker
            // 
            this.EditTimePicker.Enabled = false;
            this.EditTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EditTimePicker.Location = new System.Drawing.Point(6, 65);
            this.EditTimePicker.Name = "EditTimePicker";
            this.EditTimePicker.ShowUpDown = true;
            this.EditTimePicker.Size = new System.Drawing.Size(94, 20);
            this.EditTimePicker.TabIndex = 4;
            // 
            // EditDatePicker
            // 
            this.EditDatePicker.Enabled = false;
            this.EditDatePicker.Location = new System.Drawing.Point(6, 39);
            this.EditDatePicker.Name = "EditDatePicker";
            this.EditDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EditDatePicker.TabIndex = 3;
            // 
            // RemoveEventButton
            // 
            this.RemoveEventButton.Enabled = false;
            this.RemoveEventButton.Location = new System.Drawing.Point(237, 95);
            this.RemoveEventButton.Name = "RemoveEventButton";
            this.RemoveEventButton.Size = new System.Drawing.Size(87, 23);
            this.RemoveEventButton.TabIndex = 1;
            this.RemoveEventButton.Text = "Remove Event";
            this.RemoveEventButton.UseVisualStyleBackColor = true;
            this.RemoveEventButton.Click += new System.EventHandler(this.RemoveEventButtonClick);
            // 
            // EditDescription
            // 
            this.EditDescription.Enabled = false;
            this.EditDescription.Location = new System.Drawing.Point(6, 13);
            this.EditDescription.Name = "EditDescription";
            this.EditDescription.Size = new System.Drawing.Size(306, 20);
            this.EditDescription.TabIndex = 0;
            // 
            // EditEventButton
            // 
            this.EditEventButton.Enabled = false;
            this.EditEventButton.Location = new System.Drawing.Point(156, 95);
            this.EditEventButton.Name = "EditEventButton";
            this.EditEventButton.Size = new System.Drawing.Size(75, 23);
            this.EditEventButton.TabIndex = 2;
            this.EditEventButton.Text = "Edit Event";
            this.EditEventButton.UseVisualStyleBackColor = true;
            this.EditEventButton.Click += new System.EventHandler(this.EditEventButtonClick);
            // 
            // SchedulerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EventPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.monthCalendar1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SchedulerWindow";
            this.Text = "Scheduler";
            this.Activated += new System.EventHandler(this.SchedulerWindowActivated);
            this.Deactivate += new System.EventHandler(this.SchedulerWindowDeactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchedulerWindowFormClosing);
            this.Click += new System.EventHandler(this.SchedulerWindowClick);
            this.Resize += new System.EventHandler(this.SchedulerWindowResize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.EventPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel EventPanel;
        private System.Windows.Forms.DataGridView EventTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeUntil;
        private System.Windows.Forms.DateTimePicker EditTimePicker;
        private System.Windows.Forms.DateTimePicker EditDatePicker;
        private System.Windows.Forms.Button EditEventButton;
        private System.Windows.Forms.Button RemoveEventButton;
        private System.Windows.Forms.TextBox EditDescription;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button CancelEditButton;
    }
}


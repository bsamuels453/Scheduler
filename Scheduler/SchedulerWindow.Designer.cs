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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.menuStrip1.SuspendLayout();
            this.EventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(61, 25);
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
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
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
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.AddEventToolStripMenuItemClick);
            // 
            // exportEventsToolStripMenuItem
            // 
            this.exportEventsToolStripMenuItem.Enabled = false;
            this.exportEventsToolStripMenuItem.Name = "exportEventsToolStripMenuItem";
            this.exportEventsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.EventPanel.Size = new System.Drawing.Size(566, 362);
            this.EventPanel.TabIndex = 20;
            // 
            // EventTable
            // 
            this.EventTable.AllowUserToAddRows = false;
            this.EventTable.AllowUserToDeleteRows = false;
            this.EventTable.AllowUserToResizeColumns = false;
            this.EventTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.EventTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.EventTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EventTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.EventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.DateAt,
            this.TimeAt,
            this.TimeUntil});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EventTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.EventTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EventTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventTable.Location = new System.Drawing.Point(2, 0);
            this.EventTable.MultiSelect = false;
            this.EventTable.Name = "EventTable";
            this.EventTable.ReadOnly = true;
            this.EventTable.RowHeadersVisible = false;
            this.EventTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.EventTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.EventTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EventTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EventTable.Size = new System.Drawing.Size(453, 359);
            this.EventTable.TabIndex = 4;
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
            // SchedulerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 573);
            this.Controls.Add(this.EventPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.monthCalendar1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SchedulerWindow";
            this.Text = "Scheduler";
            this.Activated += new System.EventHandler(this.SchedulerWindowActivated);
            this.Deactivate += new System.EventHandler(this.SchedulerWindowDeactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchedulerWindowFormClosing);
            this.Resize += new System.EventHandler(this.SchedulerWindowResize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.EventPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeUntil;
    }
}


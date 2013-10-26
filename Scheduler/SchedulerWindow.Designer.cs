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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerWindow));
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
            this.label6 = new System.Windows.Forms.Label();
            this.CancellationComboBox = new System.Windows.Forms.ComboBox();
            this.CancButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventTable
            // 
            this.EventTable.AllowUserToAddRows = false;
            this.EventTable.AllowUserToDeleteRows = false;
            this.EventTable.AllowUserToResizeColumns = false;
            this.EventTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EventTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EventTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EventTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventTable.ColumnHeadersVisible = false;
            this.EventTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.DateAt,
            this.TimeAt,
            this.TimeUntil});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EventTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.EventTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EventTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventTable.Location = new System.Drawing.Point(18, 206);
            this.EventTable.MultiSelect = false;
            this.EventTable.Name = "EventTable";
            this.EventTable.ReadOnly = true;
            this.EventTable.RowHeadersVisible = false;
            this.EventTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.EventTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EventTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EventTable.Size = new System.Drawing.Size(471, 186);
            this.EventTable.TabIndex = 3;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Column1";
            this.Description.MinimumWidth = 230;
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
            this.TimeUntil.MinimumWidth = 90;
            this.TimeUntil.Name = "TimeUntil";
            this.TimeUntil.ReadOnly = true;
            this.TimeUntil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeUntil.Width = 90;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 189);
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
            this.CancellationComboBox.SelectionChangeCommitted += new System.EventHandler(this.CancellationComboBoxSelectionChangeCommitted);
            this.CancellationComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CancellationComboBoxMouseDown);
            // 
            // CancButton
            // 
            this.CancButton.Enabled = false;
            this.CancButton.Location = new System.Drawing.Point(18, 525);
            this.CancButton.Name = "CancButton";
            this.CancButton.Size = new System.Drawing.Size(89, 23);
            this.CancButton.TabIndex = 17;
            this.CancButton.Text = "Cancel  Event";
            this.CancButton.UseVisualStyleBackColor = true;
            this.CancButton.Click += new System.EventHandler(this.CancelButtonClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.editEventToolStripMenuItem,
            this.removeEventToolStripMenuItem,
            this.exportEventsToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.AddEventToolStripMenuItemClick);
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editEventToolStripMenuItem.Text = "Edit Event";
            // 
            // removeEventToolStripMenuItem
            // 
            this.removeEventToolStripMenuItem.Name = "removeEventToolStripMenuItem";
            this.removeEventToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeEventToolStripMenuItem.Text = "Remove Event";
            // 
            // exportEventsToolStripMenuItem
            // 
            this.exportEventsToolStripMenuItem.Name = "exportEventsToolStripMenuItem";
            this.exportEventsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exportEventsToolStripMenuItem.Text = "Export Events";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // SchedulerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 563);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CancButton);
            this.Controls.Add(this.CancellationComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.EventTable);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SchedulerWindow";
            this.Text = "Scheduler";
            this.Activated += new System.EventHandler(this.SchedulerWindowActivated);
            this.Deactivate += new System.EventHandler(this.SchedulerWindowDeactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchedulerWindowFormClosing);
            this.Resize += new System.EventHandler(this.SchedulerWindowResize);
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CancellationComboBox;
        private System.Windows.Forms.Button CancButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeUntil;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}


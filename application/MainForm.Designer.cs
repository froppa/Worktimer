namespace Worktimer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Counter_TextBox = new System.Windows.Forms.TextBox();
            this.start_Button = new System.Windows.Forms.Button();
            this.pause_Button = new System.Windows.Forms.Button();
            this.stop_Button = new System.Windows.Forms.Button();
            this.Work_Timer_Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.Tray_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Counter_GroupBox = new System.Windows.Forms.GroupBox();
            this.Tray_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Counter_TextBox
            // 
            this.Counter_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Counter_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Counter_TextBox.Enabled = false;
            this.Counter_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.Counter_TextBox.Location = new System.Drawing.Point(18, 31);
            this.Counter_TextBox.Multiline = true;
            this.Counter_TextBox.Name = "Counter_TextBox";
            this.Counter_TextBox.ReadOnly = true;
            this.Counter_TextBox.Size = new System.Drawing.Size(292, 76);
            this.Counter_TextBox.TabIndex = 0;
            this.Counter_TextBox.Text = "00:00:00";
            this.Counter_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_Button
            // 
            this.start_Button.AutoEllipsis = true;
            this.start_Button.BackColor = System.Drawing.Color.DimGray;
            this.start_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Button.ForeColor = System.Drawing.Color.White;
            this.start_Button.Location = new System.Drawing.Point(42, 136);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(75, 29);
            this.start_Button.TabIndex = 1;
            this.start_Button.Text = "Start";
            this.start_Button.UseVisualStyleBackColor = false;
            this.start_Button.Click += new System.EventHandler(this.start_Click);
            // 
            // pause_Button
            // 
            this.pause_Button.BackColor = System.Drawing.Color.DimGray;
            this.pause_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_Button.Enabled = false;
            this.pause_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_Button.ForeColor = System.Drawing.Color.White;
            this.pause_Button.Location = new System.Drawing.Point(123, 136);
            this.pause_Button.Name = "pause_Button";
            this.pause_Button.Size = new System.Drawing.Size(75, 29);
            this.pause_Button.TabIndex = 2;
            this.pause_Button.Text = "Pause";
            this.pause_Button.UseVisualStyleBackColor = false;
            this.pause_Button.Click += new System.EventHandler(this.pause_Click);
            // 
            // stop_Button
            // 
            this.stop_Button.BackColor = System.Drawing.Color.DimGray;
            this.stop_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_Button.Enabled = false;
            this.stop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_Button.ForeColor = System.Drawing.Color.White;
            this.stop_Button.Location = new System.Drawing.Point(204, 136);
            this.stop_Button.Name = "stop_Button";
            this.stop_Button.Size = new System.Drawing.Size(75, 29);
            this.stop_Button.TabIndex = 3;
            this.stop_Button.Text = "Stop";
            this.stop_Button.UseVisualStyleBackColor = false;
            this.stop_Button.Click += new System.EventHandler(this.stop_Click);
            // 
            // Work_Timer_Tray
            // 
            this.Work_Timer_Tray.ContextMenuStrip = this.Tray_Menu;
            this.Work_Timer_Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Work_Timer_Tray.Icon")));
            this.Work_Timer_Tray.Text = "Worktimer - "; // How do i get the damn time.. and make it update.
            this.Work_Timer_Tray.Visible = true;
            this.Work_Timer_Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Tray_Menu
            // 
            this.Tray_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator1,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.Tray_Menu.Name = "Tray_Menu";
            this.Tray_Menu.Size = new System.Drawing.Size(117, 120);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Counter_GroupBox
            // 
            this.Counter_GroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.Counter_GroupBox.Name = "Counter_GroupBox";
            this.Counter_GroupBox.Size = new System.Drawing.Size(304, 109);
            this.Counter_GroupBox.TabIndex = 4;
            this.Counter_GroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 184);
            this.Controls.Add(this.stop_Button);
            this.Controls.Add(this.pause_Button);
            this.Controls.Add(this.start_Button);
            this.Controls.Add(this.Counter_TextBox);
            this.Controls.Add(this.Counter_GroupBox);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worktimer";
            this.Tray_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Counter_TextBox;
        private System.Windows.Forms.Button pause_Button;
        private System.Windows.Forms.Button stop_Button;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.NotifyIcon Work_Timer_Tray;
        private System.Windows.Forms.ContextMenuStrip Tray_Menu;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox Counter_GroupBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}


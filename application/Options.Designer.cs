namespace Worktimer
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.rbtn_SaveTxt = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtn_SaveDB = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DbHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DbName = new System.Windows.Forms.TextBox();
            this.txt_DbUser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_BrowseTxtFolder = new System.Windows.Forms.Button();
            this.txt_TxtPath = new System.Windows.Forms.TextBox();
            this.btn_CancelOptions = new System.Windows.Forms.Button();
            this.btn_ApplyOptions = new System.Windows.Forms.Button();
            this.btn_SaveOptions = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.cbTray = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_SaveTxt
            // 
            this.rbtn_SaveTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_SaveTxt.AutoSize = true;
            this.rbtn_SaveTxt.Location = new System.Drawing.Point(4, 31);
            this.rbtn_SaveTxt.Name = "rbtn_SaveTxt";
            this.rbtn_SaveTxt.Size = new System.Drawing.Size(107, 17);
            this.rbtn_SaveTxt.TabIndex = 0;
            this.rbtn_SaveTxt.TabStop = true;
            this.rbtn_SaveTxt.Text = "Save to a text file";
            this.rbtn_SaveTxt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.CausesValidation = false;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.rbtn_SaveDB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.rbtn_SaveTxt, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(562, 220);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // rbtn_SaveDB
            // 
            this.rbtn_SaveDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtn_SaveDB.AutoSize = true;
            this.rbtn_SaveDB.Location = new System.Drawing.Point(3, 79);
            this.rbtn_SaveDB.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.rbtn_SaveDB.Name = "rbtn_SaveDB";
            this.rbtn_SaveDB.Size = new System.Drawing.Size(109, 17);
            this.rbtn_SaveDB.TabIndex = 7;
            this.rbtn_SaveDB.TabStop = true;
            this.rbtn_SaveDB.Text = "Save to database";
            this.rbtn_SaveDB.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_DbPass, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_DbHost, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_DbName, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_DbUser, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(118, 79);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(433, 140);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Database Name";
            // 
            // txt_DbPass
            // 
            this.txt_DbPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_DbPass.Location = new System.Drawing.Point(106, 75);
            this.txt_DbPass.Name = "txt_DbPass";
            this.txt_DbPass.Size = new System.Drawing.Size(239, 20);
            this.txt_DbPass.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Host";
            // 
            // txt_DbHost
            // 
            this.txt_DbHost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_DbHost.Location = new System.Drawing.Point(106, 7);
            this.txt_DbHost.Name = "txt_DbHost";
            this.txt_DbHost.Size = new System.Drawing.Size(239, 20);
            this.txt_DbHost.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // txt_DbName
            // 
            this.txt_DbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_DbName.Location = new System.Drawing.Point(106, 110);
            this.txt_DbName.Name = "txt_DbName";
            this.txt_DbName.Size = new System.Drawing.Size(239, 20);
            this.txt_DbName.TabIndex = 11;
            // 
            // txt_DbUser
            // 
            this.txt_DbUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_DbUser.Location = new System.Drawing.Point(106, 42);
            this.txt_DbUser.Name = "txt_DbUser";
            this.txt_DbUser.Size = new System.Drawing.Size(239, 20);
            this.txt_DbUser.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.05028F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.94972F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_BrowseTxtFolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_TxtPath, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(118, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 33);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Path";
            // 
            // btn_BrowseTxtFolder
            // 
            this.btn_BrowseTxtFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_BrowseTxtFolder.Location = new System.Drawing.Point(361, 5);
            this.btn_BrowseTxtFolder.Name = "btn_BrowseTxtFolder";
            this.btn_BrowseTxtFolder.Size = new System.Drawing.Size(69, 23);
            this.btn_BrowseTxtFolder.TabIndex = 1;
            this.btn_BrowseTxtFolder.Text = "Browse";
            this.btn_BrowseTxtFolder.UseVisualStyleBackColor = true;
            this.btn_BrowseTxtFolder.Click += new System.EventHandler(this.btn_BrowseTxtFolder_Click);
            // 
            // txt_TxtPath
            // 
            this.txt_TxtPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_TxtPath.Location = new System.Drawing.Point(107, 6);
            this.txt_TxtPath.Name = "txt_TxtPath";
            this.txt_TxtPath.Size = new System.Drawing.Size(238, 20);
            this.txt_TxtPath.TabIndex = 2;
            // 
            // btn_CancelOptions
            // 
            this.btn_CancelOptions.Location = new System.Drawing.Point(417, 401);
            this.btn_CancelOptions.Name = "btn_CancelOptions";
            this.btn_CancelOptions.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelOptions.TabIndex = 3;
            this.btn_CancelOptions.Text = "Cancel";
            this.btn_CancelOptions.UseVisualStyleBackColor = true;
            this.btn_CancelOptions.Click += new System.EventHandler(this.btn_CancelOptions_Click);
            // 
            // btn_ApplyOptions
            // 
            this.btn_ApplyOptions.Location = new System.Drawing.Point(498, 401);
            this.btn_ApplyOptions.Name = "btn_ApplyOptions";
            this.btn_ApplyOptions.Size = new System.Drawing.Size(75, 23);
            this.btn_ApplyOptions.TabIndex = 4;
            this.btn_ApplyOptions.Text = "Apply";
            this.btn_ApplyOptions.UseVisualStyleBackColor = true;
            this.btn_ApplyOptions.Click += new System.EventHandler(this.btn_ApplyOptions_Click);
            // 
            // btn_SaveOptions
            // 
            this.btn_SaveOptions.Location = new System.Drawing.Point(336, 401);
            this.btn_SaveOptions.Name = "btn_SaveOptions";
            this.btn_SaveOptions.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveOptions.TabIndex = 5;
            this.btn_SaveOptions.Text = "Ok";
            this.btn_SaveOptions.UseVisualStyleBackColor = true;
            this.btn_SaveOptions.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabGeneral);
            this.tabOptions.Location = new System.Drawing.Point(3, 2);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(579, 393);
            this.tabOptions.TabIndex = 6;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.cbTray);
            this.tabGeneral.Controls.Add(this.tableLayoutPanel3);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(571, 367);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // cbTray
            // 
            this.cbTray.AutoSize = true;
            this.cbTray.Location = new System.Drawing.Point(6, 244);
            this.cbTray.Name = "cbTray";
            this.cbTray.Size = new System.Drawing.Size(163, 17);
            this.cbTray.TabIndex = 3;
            this.cbTray.Text = "Minimize to tray when closing";
            this.cbTray.UseVisualStyleBackColor = true;
            this.cbTray.CheckedChanged += new System.EventHandler(this.cbTray_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 436);
            this.Controls.Add(this.tabOptions);
            this.Controls.Add(this.btn_SaveOptions);
            this.Controls.Add(this.btn_ApplyOptions);
            this.Controls.Add(this.btn_CancelOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_SaveTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rbtn_SaveDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DbHost;
        private System.Windows.Forms.TextBox txt_DbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DbName;
        private System.Windows.Forms.Button btn_CancelOptions;
        private System.Windows.Forms.Button btn_ApplyOptions;
        private System.Windows.Forms.Button btn_SaveOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_BrowseTxtFolder;
        private System.Windows.Forms.TextBox txt_TxtPath;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.CheckBox cbTray;
    }
}
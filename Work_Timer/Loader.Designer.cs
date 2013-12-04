namespace Worktimer
{
    partial class Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.lbl_BootText = new System.Windows.Forms.Label();
            this.pb_Loader = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_BootText
            // 
            this.lbl_BootText.AutoSize = true;
            this.lbl_BootText.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BootText.Location = new System.Drawing.Point(12, 9);
            this.lbl_BootText.Name = "lbl_BootText";
            this.lbl_BootText.Size = new System.Drawing.Size(226, 26);
            this.lbl_BootText.TabIndex = 0;
            this.lbl_BootText.Text = "Configuring for first use...";
            // 
            // pb_Loader
            // 
            this.pb_Loader.Location = new System.Drawing.Point(17, 73);
            this.pb_Loader.Name = "pb_Loader";
            this.pb_Loader.Size = new System.Drawing.Size(363, 23);
            this.pb_Loader.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This might take a few seconds.";
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_Loader);
            this.Controls.Add(this.lbl_BootText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worktimer";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BootText;
        private System.Windows.Forms.ProgressBar pb_Loader;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
namespace ArmyProject.PL.FRM_Backup_Restore
{
    partial class BackupForm
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
            this.backupControl11 = new ArmyProject.PL.FRM_Backup_Restore.BackupControl1();
            this.SuspendLayout();
            // 
            // backupControl11
            // 
            this.backupControl11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.backupControl11.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.backupControl11.Appearance.Options.UseBackColor = true;
            this.backupControl11.Appearance.Options.UseForeColor = true;
            this.backupControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupControl11.Location = new System.Drawing.Point(0, 0);
            this.backupControl11.Name = "backupControl11";
            this.backupControl11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backupControl11.Size = new System.Drawing.Size(1019, 467);
            this.backupControl11.TabIndex = 0;
            this.backupControl11.Load += new System.EventHandler(this.backupControl11_Load);
            // 
            // BackupForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 467);
            this.Controls.Add(this.backupControl11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupForm";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BackupControl1 backupControl11;

    }
}
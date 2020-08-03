namespace ArmyProject.PL.FRM_Backup_Restore
{
    partial class RestoreForm
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
            this.restoreControl11 = new ArmyProject.PL.FRM_Backup_Restore.RestoreControl1();
            this.SuspendLayout();
            // 
            // restoreControl11
            // 
            this.restoreControl11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.restoreControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.restoreControl11.Appearance.Options.UseBackColor = true;
            this.restoreControl11.Appearance.Options.UseForeColor = true;
            this.restoreControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restoreControl11.Location = new System.Drawing.Point(0, 0);
            this.restoreControl11.Name = "restoreControl11";
            this.restoreControl11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.restoreControl11.Size = new System.Drawing.Size(1019, 437);
            this.restoreControl11.TabIndex = 0;
            // 
            // RestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 437);
            this.Controls.Add(this.restoreControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestoreForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoreForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RestoreControl1 restoreControl11;
    }
}
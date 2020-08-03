namespace ArmyProject.PL
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.loginUserControl1 = new ArmyProject.PL.LoginUserControl();
            this.SuspendLayout();
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.loginUserControl1.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.loginUserControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.loginUserControl1.Appearance.Options.UseBackColor = true;
            this.loginUserControl1.Appearance.Options.UseFont = true;
            this.loginUserControl1.Appearance.Options.UseForeColor = true;
            this.loginUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUserControl1.Location = new System.Drawing.Point(0, 0);
            this.loginUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginUserControl1.Size = new System.Drawing.Size(1019, 467);
            this.loginUserControl1.TabIndex = 0;
            this.loginUserControl1.Load += new System.EventHandler(this.loginUserControl1_Load);
            // 
            // Frm_Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 467);
            this.Controls.Add(this.loginUserControl1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Frm_Login.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة تسجيل الدخول :";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginUserControl loginUserControl1;

    }
}
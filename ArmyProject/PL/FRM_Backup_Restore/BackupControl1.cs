using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;

namespace ArmyProject.PL.FRM_Backup_Restore
{
    public partial class BackupControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection con = new SqlConnection(@"server = .\SQLEXPRESS;Database=Army_DB;Integrated Security = true");
        SqlCommand cmd; 
        public BackupControl1()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textFileName.Text = folderBrowserDialog1.SelectedPath; 
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            string fileName = this.textFileName.Text + "\\Army_DB" + DateTime.Now.ToShortDateString().Replace('/', '-') +
                " - " + DateTime.Now.ToShortTimeString().Replace(':', '-');
            string strQuery = "Backup Database Army_DB to Disk = '" + fileName + " .bac'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء نسخة احتياطية بنجاح ", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

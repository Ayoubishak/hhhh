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

namespace ArmyProject.PL.FRM_Backup_Restore
{
    public partial class RestoreControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection con = new SqlConnection(@"server = .\SQLEXPRESS;Database=master;Integrated Security = true");
        SqlCommand cmd; 
        public RestoreControl1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textFileName.Text = openFileDialog1.FileName;
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            string strQuery = "ALTER Database Army_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Army_DB From Disk = '" + this.textFileName.Text + "' WITH REPLACE";


            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة نسخة احتياطية بنجاح ", "استعادة النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            frm.Close();
            frm.Dispose();
        }
    }
}

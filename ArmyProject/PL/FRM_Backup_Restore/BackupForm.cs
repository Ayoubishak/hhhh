using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ArmyProject.PL.FRM_Backup_Restore
{
    public partial class BackupForm : DevExpress.XtraEditors.XtraForm
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {

        }

        private void backupControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
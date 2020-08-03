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

namespace ArmyProject.PL.FRM_Settings
{
    public partial class UserControlDeleteInfo : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlDeleteInfo()
        {
            InitializeComponent();
        }

        private void buttonDeleteAllStudents_Click(object sender, EventArgs e)
        {
            BL.CLS_SettingsDeleteFullInfo settings = new BL.CLS_SettingsDeleteFullInfo();
            if(MessageBox.Show("هل تريد فعلا حذف جميع الطلاب","عملية الحذف",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                settings.DeleteAllStudents();
                MessageBox.Show("تم حذف جميع الطلاب", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteAllGovernorates_Click(object sender, EventArgs e)
        {
            BL.CLS_SettingsDeleteFullInfo settings = new BL.CLS_SettingsDeleteFullInfo();
            if (MessageBox.Show("هل تريد فعلا حذف جميع المحافظات", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                settings.DeleteAllGovernorates();
                MessageBox.Show("تم حذف جميع المحافظات", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteAllArrivals_Click(object sender, EventArgs e)
        {
            BL.CLS_SettingsDeleteFullInfo settings = new BL.CLS_SettingsDeleteFullInfo();
            if (MessageBox.Show("هل تريد فعلا حذف جميع محطات الوصول", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                settings.DeleteAllArrivalStations();
                MessageBox.Show("تم حذف جميع محطات الوصول", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonDeleteAllUsers_Click(object sender, EventArgs e)
        {
            BL.CLS_SettingsDeleteFullInfo settings = new BL.CLS_SettingsDeleteFullInfo();
            if (MessageBox.Show("هل تريد فعلا حذف جميع المستخدمين ", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                settings.DeleteAllUsers();
                MessageBox.Show("تم حذف جميع المستخدمين", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteAllDegrees_Click(object sender, EventArgs e)
        {
            BL.CLS_SettingsDeleteFullInfo settings = new BL.CLS_SettingsDeleteFullInfo();
            if (MessageBox.Show("هل تريد فعلا حذف جميع المؤهلات ", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                settings.DeleteAllDegrees();
                MessageBox.Show("تم حذف جميع المؤهلات", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteAllRecurting_Click(object sender, EventArgs e)
        {
            BL.CLS_SettingsDeleteFullInfo settings = new BL.CLS_SettingsDeleteFullInfo();
            if (MessageBox.Show("هل تريد فعلا حذف جميع مناطق التجنيد ", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                settings.DeleteAllRecruitingAreas();
                MessageBox.Show("تم حذف جميع مناطق التجنيد", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteAllTransports_Click(object sender, EventArgs e)
        {
            BL.CLS_SettingsDeleteFullInfo settings = new BL.CLS_SettingsDeleteFullInfo();
            if (MessageBox.Show("هل تريد فعلا حذف جميع طرق النقل ", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                settings.DeleteAllTransports();
                MessageBox.Show("تم حذف جميع طرق النقل", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}

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

namespace ArmyProject.PL
{
    public partial class Frm_StudentGrid : DevExpress.XtraEditors.XtraUserControl
    {
        public Frm_StudentGrid()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //governorates_TBLTableAdapter1.Fill(army_DBDataSetViewStudents.Governorates_TBL);
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            this.students_TBLTableAdapter1.Fill(army_DBDataSetForGrid.Students_TBL);

        }
    }
}

using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArmyProject.PL
{
    //MainPageDashboard  نافذة شغاله ف البرنامج
    public partial class Frm_Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private static Frm_Main frm;
        static void frm_FormClosed (object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Frm_Main getMainForm
        {
            get
            {
                if(frm == null)
                {
                    frm = new Frm_Main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Frm_Main()
        {
            InitializeComponent();
            if(frm == null)
            {
                frm = this;
            }
            this.accordionControlElementStudents.Enabled = false;
            this.accordionControlElementHoliday.Enabled = false;
            this.accordionControlElementArrival_Stations.Enabled = false;
            this.accordionControlElementSanctions.Enabled = false;
            this.accordionControlElementHistory.Enabled = false;
            this.accordionControlElementUsers.Enabled = false;
            this.accordionControlElementMakeBackup.Enabled = false;
            this.accordionControlElementGetBackup.Enabled = false;

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new Views.Students_TBLCollectionView.Students_TBLCollectionView() { Dock = DockStyle.Fill });

            //fluentDesignFormContainer1.Controls.Add(new Frm_StudentGrid() { Dock = DockStyle.Fill});
            //fluentDesignFormContainer1.Controls.Add(new Frm_Dashboard() { Dock = DockStyle.Fill });
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        //accordionControlElement_Logout Logout_Button
        private void accordionControlElement_Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Button Add Student
        private void accordionControlElement_AddStudent_Click(object sender, EventArgs e)
        {
            //fluentDesignFormContainer1.Controls.Remove(new Frm_Dashboard() { Dock = DockStyle.Fill });
            //fluentDesignFormContainer1.Controls.Add(new FrmStudentAdd() { Dock = DockStyle.Fill });
            Frm_StudentAdd frm = new Frm_StudentAdd();
            frm.ShowDialog();
      
        }

        private void accordionControlElementLogin_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        //ادارة الطلاب 
        private void accordionControlElement_StudentManage_Click(object sender, EventArgs e)
        {
            //fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Frm_StudentGrid() { Dock = DockStyle.Fill});
            
        }

        private void accordionControlElement24_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new Views.Students_TBLCollectionView.Students_TBLCollectionView() { Dock = DockStyle.Fill });
        }
    }
}

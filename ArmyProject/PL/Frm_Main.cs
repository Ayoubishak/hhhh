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
            this.accordionControlElementSanctions.Enabled = false;
            this.accordionControlElementHistory.Enabled = false;
            this.accordionControlElementUsers.Enabled = false;
            this.accordionControlElementMakeBackup.Enabled = false;
            this.accordionControlElementGetBackup.Enabled =false;
            this.accordionControlElement_AddStudent.Enabled = false;
            this.accordionControlElement_StudentManage.Enabled = false;
            this.accordionControlElementFullStudentReports.Enabled = false;
            this.accordionControlElementDegreeCrud.Enabled = false;
            this.accordionControlElementSettings.Enabled = false;

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //fluentDesignFormContainer1.Controls.Add(new Views.Students_TBLCollectionView.Students_TBLCollectionView() { Dock = DockStyle.Fill });

            //fluentDesignFormContainer1.Controls.Add(new Frm_StudentGrid() { Dock = DockStyle.Fill});
            //fluentDesignFormContainer1.Controls.Add(new Frm_Dashboard() { Dock = DockStyle.Fill });
            fluentDesignFormContainer1.Controls.Add(new FRM_Settings.UserControlMainView { Dock = DockStyle.Fill });
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
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Views.Students_TBLCollectionView.Students_TBLCollectionView() { Dock = DockStyle.Fill });
            
        }

        //التقرير الشامل للطلاب
        private void accordionControlElementFullStudentsReport_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Views.Students_TBLCollectionView.Students_TBLCollectionView() { Dock = DockStyle.Fill });
        }

        //ادارة الاجازات والمحافظات
        private void accordionControlElementHoliday_Management_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new FRM_Holiday_FULL_Crud.Views.Governorates_TBLCollectionView.Governorates_TBLCollectionView() { Dock = DockStyle.Fill });
        }

        //كشف بالاجازات
        private void accordionControlElementHolidayFinalPart_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new FRM_Holiday_Arrival_Full_Crud.Views.ArrivalStations_TBLCollectionView.ArrivalStations_TBLCollectionView() { Dock = DockStyle.Fill });
        
        }

        private void accordionControlElementHoliday_Click(object sender, EventArgs e)
        {

        }

        //Manage مناطق التجنيد
        private void accordionControlElementRecruitingAreaMange_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new FRM_RecruitingAreaCrud.Views.RecruitingArea_TBLCollectionView.RecruitingArea_TBLCollectionView() { Dock = DockStyle.Fill });
        }


        // ادارة المؤهلات
        private void accordionControlElementDegreeCrud_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new FRM_Degree_Crud.Views.Degree_TBLCollectionView.Degree_TBLCollectionView() { Dock = DockStyle.Fill });
        }

        private void accordionControlElementMakeBackup_Click(object sender, EventArgs e)
        {
            FRM_Backup_Restore.BackupForm frm = new FRM_Backup_Restore.BackupForm();
            frm.ShowDialog();
        }

        private void accordionControlElementGetBackup_Click(object sender, EventArgs e)
        {
            FRM_Backup_Restore.RestoreForm frm = new FRM_Backup_Restore.RestoreForm();
            frm.ShowDialog();
        }

        private void accordionControlElementSanctions_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElementDeleteInfo_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new FRM_Settings.UserControlDeleteInfo { Dock = DockStyle.Fill });
        }

        private void accordionControlElementSettings_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElementAbout_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new FRM_Settings.UserControlAboutUs { Dock = DockStyle.Fill });
        }

        private void accordionControlElementDashboard_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(new Frm_Dashboard() { Dock = DockStyle.Fill });
        }

    }
}

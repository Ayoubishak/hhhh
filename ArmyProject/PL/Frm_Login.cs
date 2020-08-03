﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ArmyProject.PL
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.CLS_Login log = new BL.CLS_Login();
            DataTable dt = new DataTable();
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                dt = log.Login(txtUsername.Text, txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("تم تسجيل الدخول بنجاح !", "عملية الدخول", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Frm_Main frm = Frm_Main.getMainForm;
                    frm.accordionControlElementLogin.Enabled = false;
                    frm.accordionControlElementStudents.Enabled = true;
                    frm.accordionControlElementHoliday.Enabled = true;
                    frm.accordionControlElementArrival_Stations.Enabled = true;
                    frm.accordionControlElementSanctions.Enabled = true;
                    frm.accordionControlElementHistory.Enabled = true;
                    frm.accordionControlElementUsers.Enabled = true;
                    frm.accordionControlElementMakeBackup.Enabled = true;
                    frm.accordionControlElementGetBackup.Enabled = true;
                    frm.accordionControlElementArrival_Stations.Enabled = true;
                    frm.accordionControlElementSettings.Enabled = true;
                    frm.accordionControlElementMakeBackup.Enabled = true;
                    frm.accordionControlElementGetBackup.Enabled = true;
                    frm.accordionControlElement_AddStudent.Enabled = true;
                    frm.accordionControlElement_StudentManage.Enabled = true;
                    frm.accordionControlElementFullStudentReports.Enabled = true;
                    frm.accordionControlElementDegreeCrud.Enabled = true;


                    this.Close();
                }
                else
                {
                    MessageBox.Show("اسم المستخدم او كلمة السر غير صحيحه !", "تنبيه", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show("ادخل البيانات من فضلك !", "تنبيه", MessageBoxButtons.OK);

            }
            
        }
    }
}
﻿using DevExpress.XtraBars;
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
    public partial class Frm_Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new Frm_Dashboard() { Dock = DockStyle.Fill});
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        //accordionControlElement_Logout Logout_Button
        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Button Add Student
        private void accordionControlElement_AddStudent_Click(object sender, EventArgs e)
        {

        }
    }
}

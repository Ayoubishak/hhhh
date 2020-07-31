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


//Won't use it i made another one
namespace ArmyProject.PL
{
    public partial class FrmStudentAdd : DevExpress.XtraEditors.XtraUserControl
    {
        BL.CLS_Students st = new BL.CLS_Students();
        public FrmStudentAdd()
        {
            /*
            InitializeComponent();
            //comboBox of degrees المؤهل
            comboDegrees.DataSource = st.GetAllDegrees();
            comboDegrees.DisplayMember = "Name";
            comboDegrees.ValueMember = "Id";

            //comboBox of RecruitingArea منطقة التجنيد
            comboRecruitingArea.DataSource = st.GetAllRecruitingArea();
            comboRecruitingArea.DisplayMember = "Name";
            comboRecruitingArea.ValueMember = "Id";

            //comboBox of Governorates المحافظات
            comboGovernorates.DataSource = st.GetAllGovernorates();
            comboGovernorates.DisplayMember = "Name";
            comboGovernorates.ValueMember = "Id";
            */
        }
        public void validateNumericTextBox()
        {
            MessageBox.Show("Please enter only numbers.");

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_GeneralNumber.Text, "[^0-9]") 
               // || System.Text.RegularExpressions.Regex.IsMatch(textBox_Company.Text, "[^0-9]")
                )
            {
                MessageBox.Show("Please enter only numbers.");
                textBox_GeneralNumber.Text = textBox_GeneralNumber.Text.Remove(textBox_GeneralNumber.Text.Length - 1);
                //textBox_GeneralNumber.Text = textBox_Company.Text.Remove(textBox_Company.Text.Length - 1);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }

        //AddStudent Button
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            /*
             st.Add_Student(Convert.ToInt32(textBox_GeneralNumber.Text), Convert.ToInt32(textBox_Company.Text),
                textBox_Name.Text, Convert.ToString(comboDegrees.SelectedValue),
                Convert.ToString(comboRecruitingArea.SelectedValue),
                Convert.ToString(comboGovernorates.SelectedValue));
            MessageBox.Show("تم الاضافة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
             */
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {

            //this.Hide();
        }

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

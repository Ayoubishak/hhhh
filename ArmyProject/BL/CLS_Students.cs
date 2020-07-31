using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ArmyProject.BL
{
    class CLS_Students
    {

        //comboDegrees المؤهل
        public DataTable GetAllDegrees()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("SP_GetAllDegrees", null);
            return dt;
        }

        //ComboRecruitingArea منطقة التجنيد
        public DataTable GetAllRecruitingArea()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("SP_GetAllRecruitingArea", null);
            return dt;
        }

        //ComboGovernorates المحافظات
        public DataTable GetAllGovernorates()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("SP_GetAllGovernorates", null);
            return dt;
        }

        //function to add student
        public void Add_Student(int GeneralNumber, int Company, string Name, string Degree,
            string RecruitingArea, string Governorate )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@GeneralNumber", SqlDbType.Int);
            param[0].Value = GeneralNumber;
            param[1] = new SqlParameter("@Company", SqlDbType.Int);
            param[1].Value = Company;
            param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[2].Value = Name;
            param[3] = new SqlParameter("@Degree", SqlDbType.NVarChar, 50);
            param[3].Value = Degree;
            param[4] = new SqlParameter("@RecruitingArea", SqlDbType.NVarChar, 50);
            param[4].Value = RecruitingArea;
            param[5] = new SqlParameter("@Governorate", SqlDbType.NVarChar, 50);
            param[5].Value = Governorate;
            /*
            param[6] = new SqlParameter("@Degree_Id", SqlDbType.Int);
            param[6].Value = Degree_Id;
            param[7] = new SqlParameter("@RecruitingArea_Id", SqlDbType.Int);
            param[7].Value = RecruitingArea_Id;
            param[8] = new SqlParameter("@Governorate_Id", SqlDbType.Int);
            param[8].Value = Governorate_Id;
             * */
            dal.ExcuteCommand("SP_AddStudent", param);
            dal.Close();
        }

    }
}

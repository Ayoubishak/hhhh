using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ArmyProject.BL
{
    class CLS_Login
    {
        public DataTable Login(String Username, String Password)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.VarChar, 50);
            param[0].Value = Username;
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = Password;
            DataTable dt = new DataTable();
            dt = dal.SelectData("SP_Login", param);
            return dt;
        }
    }
}

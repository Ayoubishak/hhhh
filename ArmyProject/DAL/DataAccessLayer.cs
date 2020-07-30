using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ArmyProject.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlConnection;

        //constructor
        public DataAccessLayer()
        {
            sqlConnection = new SqlConnection(@"server = .\SQLEXPRESS;Database=Army_DB;Integrated Security = true");
        }

        //to open the connection
        public void Open()
        {
            if(sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        
        //to close the connection
        public void Close()
        {
            if(sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //Method to read data from database and perform procedure and get the result in DataTable
        public DataTable SelectData(String stored_procedure, SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlConnection;
            if(param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ExcuteCommand(String stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
 
        }

    }
}

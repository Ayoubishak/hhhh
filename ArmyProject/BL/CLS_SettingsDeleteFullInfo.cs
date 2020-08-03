using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ArmyProject.BL
{
    class CLS_SettingsDeleteFullInfo
    {

        public void DeleteAllStudents()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            dal.ExcuteCommand("SP_DeleteAllStudents", null);
            dal.Close();
        }
        public void DeleteAllGovernorates()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            dal.ExcuteCommand("SP_DeleteAllGovernorates", null);
            dal.Close();
        }

        //where users type = 0 not 1
        public void DeleteAllUsers()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            dal.ExcuteCommand("SP_DeleteAllUsers", null);
            dal.Close();
        }
        public void DeleteAllDegrees()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            dal.ExcuteCommand("SP_DeleteAllDegrees", null);
            dal.Close();
        }
        public void DeleteAllArrivalStations()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            dal.ExcuteCommand("SP_DeleteAllArrivalStations", null);
            dal.Close();
        }
        public void DeleteAllHistory()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            dal.ExcuteCommand("SP_DeleteAllHistory", null);
            dal.Close();
        }
        public void DeleteAllTransports()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            dal.ExcuteCommand("SP_DeleteAllTransports", null);
            dal.Close();
        }
        public void DeleteAllRecruitingAreas()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            dal.ExcuteCommand("SP_DeleteAllRecruitingAreas", null);
            dal.Close();
        }

    }
}

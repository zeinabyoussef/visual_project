using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Project_visual.BL
{
    internal class CLS_USER
    {
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();
        //LOAD
        public DataTable Load()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADUSER" ,PR);
            return dt;
        }
        // insert data
        public void insert(string CNAME, string CUSER, string CPASSWORD, string CPERM, string CSTATE)
        {
            SqlParameter[] PR = new SqlParameter[5];
            PR[0] = new SqlParameter("CNAME", CNAME);
            PR[1] = new SqlParameter("CUSER", CUSER);
            PR[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            PR[3] = new SqlParameter("CPERM", CPERM);
            PR[4] = new SqlParameter("CSTATE", CSTATE);
            DAL.open();
            DAL.Excute("PR_INSERTUSER", PR);
            DAL.close();
        }
        // update data
        public void update(string CNAME, string CUSER, string CPASSWORD, string CPERM, int ID)
        {
            SqlParameter[] PR = new SqlParameter[5];
            PR[0] = new SqlParameter("CNAME", CNAME);
            PR[1] = new SqlParameter("CUSER", CUSER);
            PR[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            PR[3] = new SqlParameter("CPERM", CPERM);
            PR[4] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITUSER", PR);
            DAL.close();
        }
        // Delete data
        public void delete(int ID)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_DELETEUSER", PR);
            DAL.close();
        }
        // Logout
        public void logout()
        {
            SqlParameter[] PR = null;
            DAL.open();
            DAL.Excute("PR_LOGOUT", PR);
            DAL.close();
        }
        // Load data for login
        public DataTable login(string CUSER, string CPASSWORD)
        {
            SqlParameter[] PR = new SqlParameter[2];
            PR[0] = new SqlParameter("CUSER", CUSER);
            PR[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOGIN", PR);
            return dt;
        }
        // update data for login
        public void updateLogin(string CUSER, string CPASSWORD)
        {
            SqlParameter[] PR = new SqlParameter[2];
            PR[0] = new SqlParameter("CUSER", CUSER);
            PR[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DAL.open();
            DAL.Excute("PR_UPDATELOGIN", PR);
            DAL.close();
        }

        //load data for check start 
        public DataTable STARTLOADDATA()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_START", PR);
            return dt;
        }
    }
}

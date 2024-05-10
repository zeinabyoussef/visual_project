using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project_visual.BL
{
    internal class Class1
    {
        DAL.CLS_DAL DAL= new DAL.CLS_DAL();
        //Load DATA
        public DataTable load()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCAT", PR);
            return dt;
        }
        //Search DATA
        public DataTable search(string search)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_CATSEARCH", PR);
            return dt;
        }
        //Insert DATA 
        public void insert (string CAT_NAME)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("CAT_NAME" , CAT_NAME);
            DAL.open();
            DAL.Excute("P_ADDCAT" , PR);
            DAL.close();
        }
        //Update DATA 
        public void update(string CAT_NAME, int ID)
        {
            SqlParameter[] PR = new SqlParameter[2];
            PR[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            PR[1] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_EDITCAT", PR);
            DAL.close();
        }
        //Delete DATA 
        public void delete(int ID)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_DELETECAT", PR);
            DAL.close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_visual.BL
{
    internal class CLS_SELL
    {
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();
        public DataTable Load()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSELL" ,PR);
            return dt;
        }
        // load data books
        public DataTable LoadBOOKS()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKFORSELL", PR);
            return dt;
        }
        // load data student
        public DataTable LoadST()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSTFORSELL", PR);
            return dt;
        }
        // insert data
        public void Insert(string SNAME , string BTITLE , int PRICE , string BDATE)
        {
            SqlParameter[] PR = new SqlParameter[4];
            PR[0] = new SqlParameter("SNAME", SNAME);
            PR[1] = new SqlParameter("BTITLE", BTITLE);
            PR[2] = new SqlParameter("PRICE", PRICE);
            PR[3] = new SqlParameter("BDATE", BDATE);
            DAL.open();
            DAL.Excute("PR_INSERTSELL", PR);
            DAL.close();
        }
        // update data
        public void update(string SNAME, string BTITLE, int PRICE, string BDATE, int ID)
        {
            SqlParameter[] PR = new SqlParameter[5];
            PR[0] = new SqlParameter("SNAME", SNAME);
            PR[1] = new SqlParameter("BTITLE", BTITLE);
            PR[2] = new SqlParameter("PRICE", PRICE);
            PR[3] = new SqlParameter("BDATE", BDATE);
            PR[4] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_UPDATESELL", PR);
            DAL.close();
        }
        // Delete SELL
        public void delete(int ID)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_DELETESELL", PR);
            DAL.close();
        }
        // Search SELL
        public DataTable search(string search)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SEARCHSELL", PR);
            return dt;
        }
    }
}

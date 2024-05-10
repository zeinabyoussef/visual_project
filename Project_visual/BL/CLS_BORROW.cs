using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Project_visual.BL
{
    internal class CLS_BORROW
    {
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();
        public DataTable Load()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBORROW", PR);
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
        public void insert(string BNAME, string BTITLE, string BDATE1, string BDATE2, int PRICE)
        {
            SqlParameter[] PR = new SqlParameter[5];
            PR[0] = new SqlParameter("BNAME", BNAME);
            PR[1] = new SqlParameter("BTITLE", BTITLE);
            PR[2] = new SqlParameter("BDATE1", BDATE1);
            PR[3] = new SqlParameter("BDATE2", BDATE2);
            PR[4] = new SqlParameter("PRICE", PRICE);
            DAL.open();
            DAL.Excute("PR_INSERTBORROW", PR);
            DAL.close();
        }
        // update data
        public void update(string BNAME, string BTITLE, string BDATE1, string BDATE2, int PRICE, int ID)
        {
            SqlParameter[] PR = new SqlParameter[6];
            PR[0] = new SqlParameter("BNAME", BNAME);
            PR[1] = new SqlParameter("BTITLE", BTITLE);
            PR[2] = new SqlParameter("BDATE1", BDATE1);
            PR[3] = new SqlParameter("BDATE2", BDATE2);
            PR[4] = new SqlParameter("PRICE", PRICE);
            PR[5] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITBORROW", PR);
            DAL.close();
        }
        // Delete data
        public void delete(int ID)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_DELETEBORROW", PR);
            DAL.close();
        }
        // Search data
        public DataTable search(string search)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SEARCHBORROW", PR);
            return dt;
        }
    }
}

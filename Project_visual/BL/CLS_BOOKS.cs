using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Diagnostics;
using System.IO;




namespace Project_visual.BL
{
    internal class CLS_BOOKS
    {
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();
        // Load Books
        public DataTable load()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKS", PR);
            return dt;
        }
        //COMBO BOX
        public DataTable loadcategory()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCATTOCOMBOBOX", PR);
            return dt;
        }
        // Add Books
        public void insert(string TITLE, string AUTHER, string CATEGORY, string PRICE, string BDATE, string RATE, MemoryStream COVER)
        {
            SqlParameter[] PR = new SqlParameter[7];
            PR[0] = new SqlParameter("TITLE", TITLE);
            PR[1] = new SqlParameter("AUTHER", AUTHER);
            PR[2] = new SqlParameter("CATEGORY" , CATEGORY);
            PR[3] = new SqlParameter("PRICE" , PRICE);
            PR[4] = new SqlParameter("BDATE", BDATE);
            PR[5] = new SqlParameter("RATE", RATE);
            PR[6] = new SqlParameter("COVER", COVER.ToArray()); 
            DAL.open();
            DAL.Excute("PR_INSERTBOOKS", PR);
            DAL.close();
        }
        // Load Books for Edit
        public DataTable loadEdit(int ID)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEDIT", PR);
            return dt;
        }
        // Update Books
        public void update(string TITLE, string AUTHER, string CATEGORY, string PRICE, string BDATE, string RATE, MemoryStream COVER, int ID)
        {
            SqlParameter[] PR = new SqlParameter[8];
            PR[0] = new SqlParameter("TITLE", TITLE);
            PR[1] = new SqlParameter("AUTHER", AUTHER);
            PR[2] = new SqlParameter("CATEGORY", CATEGORY);
            PR[3] = new SqlParameter("PRICE", PRICE);
            PR[4] = new SqlParameter("BDATE", BDATE);
            PR[5] = new SqlParameter("RATE", RATE);
            PR[6] = new SqlParameter("COVER", COVER.ToArray());
            PR[7] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITBOOKS", PR);
            DAL.close();
        }
        // Delete Books
        public void delete(int ID)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_DELETEBOOKS", PR);
            DAL.close();
        }
        //Search DATA
        public DataTable search(string search)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_BOOKSSEARCH", PR);
            return dt;
        }
    }
}

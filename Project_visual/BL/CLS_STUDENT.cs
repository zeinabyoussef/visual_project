using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Project_visual.BL
{
    internal class CLS_STUDENT
    {

        DAL.CLS_DAL DAL = new DAL.CLS_DAL();
        public DataTable load()
        {
            SqlParameter[] PR = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADST", PR);
            return dt;
        }
        // Add Student
        public void insert(string S_NAME, string TLOCATION, string PHONE_NUMBER, string EMAIL, string SCHOOL, string DEPARTMENT, MemoryStream COVER)
        {
            SqlParameter[] PR = new SqlParameter[7];
            PR[0] = new SqlParameter("S_NAME", S_NAME);
            PR[1] = new SqlParameter("TLOCATION", TLOCATION);
            PR[2] = new SqlParameter("PHONE_NUMBER", PHONE_NUMBER);
            PR[3] = new SqlParameter("EMAIL", EMAIL);
            PR[4] = new SqlParameter("SCHOOL", SCHOOL);
            PR[5] = new SqlParameter("DEPARTMENT", DEPARTMENT);
            PR[6] = new SqlParameter("COVER", COVER.ToArray());
            DAL.open();
            DAL.Excute("PR_INSERTSTUDENT", PR);
            DAL.close();
        }
        // Load Student for Edit
        public DataTable loadEdit(int ID)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEDITSTUDENT", PR);
            return dt;
        }
        // Update Student
        public void update(string S_NAME, string TLOCATION, string PHONE_NUMBER, string EMAIL, string SCHOOL, string DEPARTMENT, MemoryStream COVER, int ID)
        {
            SqlParameter[] PR = new SqlParameter[8];
            PR[0] = new SqlParameter("S_NAME", S_NAME);
            PR[1] = new SqlParameter("TLOCATION", TLOCATION);
            PR[2] = new SqlParameter("PHONE_NUMBER", PHONE_NUMBER);
            PR[3] = new SqlParameter("EMAIL", EMAIL);
            PR[4] = new SqlParameter("SCHOOL", SCHOOL);
            PR[5] = new SqlParameter("DEPARTMENT", DEPARTMENT);
            PR[6] = new SqlParameter("COVER", COVER.ToArray());
            PR[7] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITSTUDENT", PR);
            DAL.close();
        }
        // Delete Student
        public void delete(int ID)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_DELETESTUDENT", PR);
            DAL.close();
        }
        //Search Student
        public DataTable search(string search)
        {
            SqlParameter[] PR = new SqlParameter[1];
            PR[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_STUDENTSEARCH", PR);
            return dt;
        }
    }
}

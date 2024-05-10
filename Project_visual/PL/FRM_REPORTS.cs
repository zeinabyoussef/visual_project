using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Project_visual.PL
{
    public partial class FRM_REPORTS : Form
    {
        // Instance of Class CATEGORY
        BL.Class1 BL_CAT = new BL.Class1();

        // Instance of Class BOOKS
        BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();

        // Instance of Class STUDENTS
        BL.CLS_STUDENT BLSTUDENTS = new BL.CLS_STUDENT();

        // Instance of Class SELL
        BL.CLS_SELL BLSELL = new BL.CLS_SELL();

        // Instance of Class BORROW
        BL.CLS_BORROW BLBORROW = new BL.CLS_BORROW();

        // Instance of Class USER
        BL.CLS_USER BLUSER = new BL.CLS_USER();

        public FRM_REPORTS()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FRM_REPORTS_Load(object sender, EventArgs e)
        {
            PL.FRM_MAIN Home= new PL.FRM_MAIN();
            //
            //book 
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.load();
                lb_books.Text = dt.Rows.Count.ToString();


            }
            catch { }

            //students 

            try
            {
                DataTable dt = new DataTable();
                dt = BLSTUDENTS.load();
                lb_students.Text = dt.Rows.Count.ToString();
            }
            catch { }
            //sell

            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Load();
                lb_sales.Text = dt.Rows.Count.ToString();

            }
            catch { }
            // borrow 
            try
            {
                DataTable dt = new DataTable();
                dt = BLBORROW.Load();
                lb_borrow.Text = dt.Rows.Count.ToString();
            }
            catch { }

            //kinds 
            try
            {
                DataTable dt = new DataTable();
                dt = BL_CAT.load();
                lb_kind.Text = dt.Rows.Count.ToString();
            }
            catch { }

            //users 
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.Load();
                lb_users.Text = dt.Rows.Count.ToString();
            }
            catch { }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap img=new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(img, new Rectangle(Point.Empty, panel1.Size));
            e.Graphics.DrawImage(img, 0, 0);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_visual.PL
{
    public partial class FRM_MAIN : Form
    {
        string State;
        int ID;
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

        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "STUDENTS";
            Lb_Title.Text = "الطلاب";
            //load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLSTUDENTS.load();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = " التسلسل ";
                dataGridView2.Columns[1].HeaderText = " اسم الطالب ";
                dataGridView2.Columns[2].HeaderText = " السكن ";
                dataGridView2.Columns[3].HeaderText = " رقم الهاتف ";
                dataGridView2.Columns[4].HeaderText = " ايميل ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            Lb_Title.Text = "الرئيسه";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Add Category
            if (State == "CATEGORY")
            {
                PL.FRM_ADDCAT FCATEGORY = new PL.FRM_ADDCAT();
                FCATEGORY.btn_add.Text = "اضافة";
                FCATEGORY.ID = 0;
                FCATEGORY.Show();
            }
            // Add Books
            if (State == "BOOKS")
            {
                PL.FRM_ADDBOOKS FBOOKS = new PL.FRM_ADDBOOKS();
                FBOOKS.btn_add.Text = "اضافة";
                FBOOKS.ID = 0;
                FBOOKS.Show();
            }
            // add student 

            if(State == "STUDENTS")
            {
                PL.FRM_ADDSTUDENT FBOOKS =new PL.FRM_ADDSTUDENT();
                FBOOKS.btn_add.Text = "اضافه ";
                FBOOKS.ID = 0;
                FBOOKS.Show();
            }
            //add sell 
            if (State == "SELL")
            {
                PL.FRM_MAKESELL FSELL = new PL.FRM_MAKESELL();
                FSELL.btn_add.Text = "اضافه ";
                FSELL.ID = 0;
                FSELL.Show();
            }
            //add borrow 
            if (State == "BORROW")
            {
                PL.FRM_BORROW FBORROW = new PL.FRM_BORROW();
                FBORROW.btn_add.Text = "اضافه ";
                FBORROW.ID = 0;
                FBORROW.Show();
            }
            //add user 
            if (State == "USER")
            {
                PL.FRM_ADDUSER FUSER = new PL.FRM_ADDUSER();
                FUSER.btn_add.Text = "اضافه ";
                FUSER.ID = 0;
                FUSER.Show();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "CATEGORY";
            Lb_Title.Text = "الاصناف";
            //load data
            try
            {
                DataTable dt = new DataTable();
                dt = BL_CAT.load();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = " التسلسل ";
                dataGridView2.Columns[1].HeaderText = " اسم الصنف ";
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            
            }
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            Lb_Title.Text = "الرئيسة";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Edit Category
            if (State == "CATEGORY")
            {
                PL.FRM_ADDCAT FCATEGORY = new PL.FRM_ADDCAT();
                FCATEGORY.btn_add.Text = "تعديل";
                FCATEGORY.txt_categoryName.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
                FCATEGORY.ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                FCATEGORY.Show();
            }
            // Edit Books
            else if (State == "BOOKS")
            {
                try
                {
                    PL.FRM_ADDBOOKS FBOOKS = new PL.FRM_ADDBOOKS();
                    FBOOKS.btn_add.Text = "تعديل";
                    FBOOKS.ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.loadEdit(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHER"];
                    object obj3 = dt.Rows[0]["CATEGORY"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["BDATE"];
                    object obj6 = dt.Rows[0]["RATE"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FBOOKS.txt_title.Text = obj1.ToString();
                    FBOOKS.txt_authorName.Text = obj2.ToString();
                    FBOOKS.comboBox1.Text = obj3.ToString();
                    FBOOKS.txt_bookPrice.Text = obj4.ToString();
                    FBOOKS.bookDate.Value = (DateTime)obj5;
                    FBOOKS.txt_bookRate.Text = obj6.ToString();
                    FBOOKS.bookCover.Text = obj7.ToString();
                    // Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FBOOKS.bookCover.Image = Image.FromStream(ma);
                    FBOOKS.Show();
                }
                catch { }
            }
            // Edit Student
            else if (State == "STUDENTS")
            {
                try
                {
                    PL.FRM_ADDSTUDENT FSTUDENT = new PL.FRM_ADDSTUDENT();
                    FSTUDENT.btn_add.Text = "تعديل";
                    FSTUDENT.ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLSTUDENTS.loadEdit(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["S_NAME"];
                    object obj2 = dt.Rows[0]["TLOCATION"];
                    object obj3 = dt.Rows[0]["PHONE_NUMBER"];
                    object obj4 = dt.Rows[0]["EMAIL"];
                    object obj5 = dt.Rows[0]["SCHOOL"];
                    object obj6 = dt.Rows[0]["DEPARTMENT"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FSTUDENT.txt_name.Text = obj1.ToString();
                    FSTUDENT.txt_location.Text = obj2.ToString();
                    FSTUDENT.txt_phone.Text = obj3.ToString();
                    FSTUDENT.txt_email.Text = obj4.ToString();
                    FSTUDENT.txt_school.Text = obj5.ToString();
                    FSTUDENT.txt_dept.Text = obj6.ToString();
                    FSTUDENT.bookCover.Text = obj7.ToString();
                    // Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FSTUDENT.bookCover.Image = Image.FromStream(ma);
                    FSTUDENT.Show();
                }
                catch { }
            }
            // Edit SELL
            else if (State == "SELL")
            {
                try
                {
                    PL.FRM_MAKESELL FSELL = new PL.FRM_MAKESELL();
                    FSELL.btn_add.Text = "تعديل";
                    FSELL.ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    FSELL.Show();
                }
                catch { }
            }
            // Edit Borrow
            else if (State == "BORROW")
            {
                try
                {
                    PL.FRM_BORROW FBORROW = new PL.FRM_BORROW();
                    FBORROW.btn_add.Text = "تعديل";
                    FBORROW.ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    FBORROW.Show();
                }
                catch { }
            }
            // Edit user
            else if (State == "USER")
            {
                try
                {
                    PL.FRM_ADDUSER FUSER = new PL.FRM_ADDUSER();
                    FUSER.btn_add.Text = "تعديل";
                    FUSER.ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    FUSER.Show();
                }
                catch { }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Delete Category
            if (State == "CATEGORY")
            {
                BL_CAT.delete(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE FDEL = new PL.FRM_DDELETE();
                FDEL.Show();
            }
            // Delete Books
            else if (State == "BOOKS")
            {
                BLBOOKS.delete(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE FDEL = new PL.FRM_DDELETE();
                FDEL.Show();
            }
            // Delete Student
            else if (State == "STUDENTS")
            {
                BLSTUDENTS.delete(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE FDEL = new PL.FRM_DDELETE();
                FDEL.Show();
            }
            // Delete SELL
            else if (State == "SELL")
            {
                BLSELL.delete(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE FDEL = new PL.FRM_DDELETE();
                FDEL.Show();
            }
            // Delete Borrow
            else if (State == "BORROW")
            {
                BLBORROW.delete(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE FDEL = new PL.FRM_DDELETE();
                FDEL.Show();
            }
            // Delete user
            else if (State == "USER")
            {
                BLUSER.delete(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE FDEL = new PL.FRM_DDELETE();
                FDEL.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Search Category
            if (State == "CATEGORY")
            {
                DataTable dt = new DataTable();
                dt = BL_CAT.search(textBox1.Text);
                dataGridView2.DataSource = dt;
            }
            // Search Books
            if (State == "BOOKS")
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.search(textBox1.Text);
                dataGridView2.DataSource = dt;
            }
            // Search Student
            if (State == "STUDENTS")
            {
                DataTable dt = new DataTable();
                dt = BLSTUDENTS.search(textBox1.Text);
                dataGridView2.DataSource = dt;
            }
            // Search SELL
            if (State == "SELL")
            {
                DataTable dt = new DataTable();
                dt = BLSELL.search(textBox1.Text);
                dataGridView2.DataSource = dt;
            }
            // Search Borrow
            if (State == "BORROW")
            {
                DataTable dt = new DataTable();
                dt = BLBORROW.search(textBox1.Text);
                dataGridView2.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "BOOKS";
            Lb_Title.Text = "الكتب";
            //load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.load();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = " التسلسل ";
                dataGridView2.Columns[1].HeaderText = " اسم الكتاب ";
                dataGridView2.Columns[2].HeaderText = " المؤلف ";
                dataGridView2.Columns[3].HeaderText = " التصنيف ";
                dataGridView2.Columns[4].HeaderText = " السعر ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            //for check number 
            //book 
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.load();
                lb_books.Text =dt.Rows.Count.ToString();

                
            }
            catch { }

            //students 

            try
            {
                DataTable dt = new DataTable();
                dt = BLSTUDENTS.load();
                lb_students.Text =dt.Rows.Count.ToString();
            }
            catch { }
            //sell

            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Load();
                lb_sales.Text =dt.Rows.Count.ToString();
               
            }
            catch { }
            // borrow 
            try
            {
                DataTable dt = new DataTable();
                dt = BLBORROW.Load();
               lb_borrow.Text =dt.Rows.Count.ToString();
            }
            catch { }

            //kinds 
            try
            {
                DataTable dt = new DataTable();
                dt = BL_CAT.load();
               lb_kind.Text =dt.Rows.Count.ToString();
            }
            catch { }

            //users 
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.Load();
               lb_users.Text =dt.Rows.Count.ToString(); 
            }
            catch { }
         





            // for prem 
            if (lb_prem.Text=="مدير")
            {
                button14.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                button14.Enabled = false;
                button5.Enabled = false;

            }
            if (State == "CATEGORY")
            {
                //load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BL_CAT.load();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].HeaderText = " التسلسل ";
                    dataGridView2.Columns[1].HeaderText = " اسم الصنف ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (State == "BOOKS")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "BOOKS";
                Lb_Title.Text = "الكتب";
                //load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.load();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].HeaderText = " التسلسل ";
                    dataGridView2.Columns[1].HeaderText = " اسم الكتاب ";
                    dataGridView2.Columns[2].HeaderText = " المؤلف ";
                    dataGridView2.Columns[3].HeaderText = " التصنيف ";
                    dataGridView2.Columns[4].HeaderText = " السعر ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "STUDENTS")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "STUDENTS";
                Lb_Title.Text = "الطلاب";
                //load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLSTUDENTS.load();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].HeaderText = " التسلسل ";
                    dataGridView2.Columns[1].HeaderText = " اسم الطالب ";
                    dataGridView2.Columns[2].HeaderText = " السكن ";
                    dataGridView2.Columns[3].HeaderText = " رقم الهاتف ";
                    dataGridView2.Columns[4].HeaderText = " ايميل ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (State == "SELL")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "SELL";
                Lb_Title.Text = "البيع";
                //load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLSELL.Load();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].HeaderText = " التسلسل ";
                    dataGridView2.Columns[1].HeaderText = " المشتري ";
                    dataGridView2.Columns[2].HeaderText = " اسم الكتاب ";
                    dataGridView2.Columns[3].HeaderText = "  السعر ";
                    dataGridView2.Columns[4].HeaderText = " التاريخ ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (State == "BORROW")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "BORROW";
                Lb_Title.Text = "الاستعارة";
                //load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBORROW.Load();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].HeaderText = " التسلسل ";
                    dataGridView2.Columns[1].HeaderText = " اسم المشتري ";
                    dataGridView2.Columns[2].HeaderText = " اسم الكتاب ";
                    dataGridView2.Columns[3].HeaderText = " بداية الاستعارة ";
                    dataGridView2.Columns[4].HeaderText = " نهاية الاستعارة ";
                    dataGridView2.Columns[5].HeaderText = "  السعر ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "USER")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "USER";
                Lb_Title.Text = "المستخدمين";
                //load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLUSER.Load();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].HeaderText = " التسلسل ";
                    dataGridView2.Columns[1].HeaderText = " الاسم الكامل ";
                    dataGridView2.Columns[2].HeaderText = " اسم المستخدم ";
                    dataGridView2.Columns[3].HeaderText = " كلمة السر ";
                    dataGridView2.Columns[4].HeaderText = " الصلاحية ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /*Details*/

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "SELL";
            Lb_Title.Text = "البيع";
            //load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Load();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = " التسلسل ";
                dataGridView2.Columns[1].HeaderText = " المشتري ";
                dataGridView2.Columns[2].HeaderText = " اسم الكتاب ";
                dataGridView2.Columns[3].HeaderText = "  السعر ";
                dataGridView2.Columns[4].HeaderText = " التاريخ ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "BORROW";
            Lb_Title.Text = "الاستعارة";
            //load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLBORROW.Load();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = " التسلسل ";
                dataGridView2.Columns[1].HeaderText = " اسم المشتري ";
                dataGridView2.Columns[2].HeaderText = " اسم الكتاب ";
                dataGridView2.Columns[3].HeaderText = " بداية الاستعارة ";
                dataGridView2.Columns[4].HeaderText = " نهاية الاستعارة ";
                dataGridView2.Columns[5].HeaderText = "  السعر ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "USER";
            Lb_Title.Text = "المستخدمين";
            //load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.Load();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = " التسلسل ";
                dataGridView2.Columns[1].HeaderText = " الاسم الكامل ";
                dataGridView2.Columns[2].HeaderText = " اسم المستخدم ";
                dataGridView2.Columns[3].HeaderText = " كلمة السر ";
                dataGridView2.Columns[4].HeaderText = " الصلاحية ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            PL.FRM_LOGIN FLOG = new PL.FRM_LOGIN();
            BLUSER.logout();
            this.Hide();
            FLOG.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDCAT FCATEGORY = new PL.FRM_ADDCAT();
            FCATEGORY.btn_add.Text = "اضافة";
            FCATEGORY.ID = 0;
            FCATEGORY.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDBOOKS FBOOKS = new PL.FRM_ADDBOOKS();
            FBOOKS.btn_add.Text = "اضافة";
            FBOOKS.ID = 0;
            FBOOKS.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDSTUDENT FBOOKS = new PL.FRM_ADDSTUDENT();
            FBOOKS.btn_add.Text = "اضافه ";
            FBOOKS.ID = 0;
            FBOOKS.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PL.FRM_MAKESELL FSELL = new PL.FRM_MAKESELL();
            FSELL.btn_add.Text = "اضافه ";
            FSELL.ID = 0;
            FSELL.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PL.FRM_BORROW FBORROW = new PL.FRM_BORROW();
            FBORROW.btn_add.Text = "اضافه ";
            FBORROW.ID = 0;
            FBORROW.Show();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            PL.FRM_REPORTS Report = new PL.FRM_REPORTS();
            Report.Show();
        }

        private void P_HOME_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

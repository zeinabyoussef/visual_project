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
    public partial class FRM_ADDSTUDENT : Form
    {
        public int ID;
        public FRM_ADDSTUDENT()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            var result = OFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                bookCover.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_location.Text == "" || txt_email.Text == "")
            {
                PL.FRM_ERRORINSERT FRM_ERROR = new PL.FRM_ERRORINSERT();
                FRM_ERROR.Show();
            }
            else
            {
                if (ID == 0)
                {
                    MemoryStream ma = new MemoryStream();
                    bookCover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Add
                    BL.CLS_STUDENT BLSTUDENT = new BL.CLS_STUDENT();
                    BLSTUDENT.insert(txt_name.Text, txt_location.Text, txt_phone.Text, txt_email.Text, txt_school.Text, txt_dept.Text, ma);
                    FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {
                    MemoryStream ma = new MemoryStream();
                    bookCover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Edit
                    BL.CLS_STUDENT BLSTUDENT = new BL.CLS_STUDENT();
                    BLSTUDENT.update(txt_name.Text, txt_location.Text, txt_phone.Text, txt_email.Text, txt_school.Text, txt_dept.Text, ma, ID);
                    FRM_DEDIT FEDIT = new FRM_DEDIT();
                    FEDIT.Show();
                    this.Close();
                }
            }
        }

        private void FRM_ADDBOOKS_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_ADDCAT FCATEGORY = new PL.FRM_ADDCAT();
            FCATEGORY.btn_add.Text = "اضافة";
            FCATEGORY.ID = 0;
            FCATEGORY.Show();
        }
    }
}

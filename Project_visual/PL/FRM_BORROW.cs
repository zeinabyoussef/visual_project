using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_visual.PL
{
    public partial class FRM_BORROW : Form
    {
        public int ID;
        public FRM_BORROW()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "")
            {
                PL.FRM_ERRORINSERT FRM_ERROR = new PL.FRM_ERRORINSERT();
                FRM_ERROR.Show();
            }
            else
            {
                if (ID == 0)
                {
                    // Add
                    BL.CLS_BORROW BLBORROW = new BL.CLS_BORROW();
                    BLBORROW.insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(bookDate.Value), Convert.ToString(borrowEnd.Value), Convert.ToInt32(txt_title.Text));
                    FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {
                    // Edit
                    BL.CLS_BORROW BLBORROW = new BL.CLS_BORROW();
                    BLBORROW.update(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(bookDate.Value), Convert.ToString(borrowEnd.Value), Convert.ToInt32(txt_title.Text), ID);
                    FRM_DEDIT FEDIT = new FRM_DEDIT();
                    FEDIT.Show();
                    this.Close();
                }
            }
        }

        private void FRM_BORROW_Load(object sender, EventArgs e)
        {
            BL.CLS_BORROW BLBORROW = new BL.CLS_BORROW();
            //LOADBOOKS
            DataTable dt1 = new DataTable();
            dt1 = BLBORROW.LoadBOOKS();
            dataGridView2.DataSource = dt1;
            //LOADSTUDENTS
            DataTable dt2 = new DataTable();
            dt2 = BLBORROW.LoadST();
            dataGridView1.DataSource = dt2;
        }
    }
}

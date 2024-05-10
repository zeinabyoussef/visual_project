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
    public partial class FRM_MAKESELL: Form
    {
        public int ID;
        public FRM_MAKESELL()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
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
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                    BLSELL.Insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(txt_title.Text), Convert.ToString(bookDate.Value));
                    FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                    BLSELL.update(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(txt_title.Text), Convert.ToString(bookDate.Value), ID);
                    FRM_DEDIT FEDIT = new FRM_DEDIT();
                    FEDIT.Show();
                    this.Close();
                }
            }
        }
        
        private void FRM_MAKESELL_Load(object sender, EventArgs e)
        {
            BL.CLS_SELL BLSELL = new BL.CLS_SELL();
            //LOADBOOKS
            DataTable dt1 = new DataTable();
            dt1 = BLSELL.LoadBOOKS();   
            dataGridView2.DataSource = dt1;

            DataTable dt2 = new DataTable();
            dt2 = BLSELL.LoadST();
            dataGridView1.DataSource = dt2;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

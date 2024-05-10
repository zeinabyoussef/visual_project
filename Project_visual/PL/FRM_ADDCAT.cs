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
    public partial class FRM_ADDCAT : Form
    {
        public int ID;
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_categoryName.Text == "")
            {
                PL.FRM_ERRORINSERT FRM_ERROR = new PL.FRM_ERRORINSERT();
                FRM_ERROR.Show();
            }
            else
            {
                if (ID == 0)
                {
                    // Add
                    BL.Class1 BLCAT = new BL.Class1();
                    BLCAT.insert(txt_categoryName.Text);
                    FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {
                    // Edit
                    BL.Class1 BLCAT = new BL.Class1();
                    BLCAT.update(txt_categoryName.Text, ID);
                    FRM_DEDIT FEDIT = new FRM_DEDIT();
                    FEDIT.Show();
                    this.Close();
                }  
            }
        }
    }
}

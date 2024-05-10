using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_visual.PL
{
    public partial class FRM_ADDUSER : Form
    {
        public int ID;
        public FRM_ADDUSER()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_timer.Text = DateTime.Now.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_user.Text == "" || txt_perm.Text == "")
            {
                PL.FRM_ERRORINSERT FRM_ERROR = new PL.FRM_ERRORINSERT();
                FRM_ERROR.Show();
            }
            else
            {
                if (ID == 0)
                {
                    // Add
                    BL.CLS_USER BLUSER = new BL.CLS_USER();
                    BLUSER.insert(txt_name.Text, txt_user.Text, txt_password.Text, txt_perm.Text, "False");
                    FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {
                    // Edit
                    BL.CLS_USER BLUSER = new BL.CLS_USER();
                    BLUSER.update(txt_name.Text, txt_user.Text, txt_password.Text, txt_perm.Text, ID);
                    FRM_DEDIT FEDIT = new FRM_DEDIT();
                    FEDIT.Show();
                    this.Close();
                }
            }
        }
    }
}

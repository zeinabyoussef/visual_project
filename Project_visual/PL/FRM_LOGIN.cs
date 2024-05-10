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
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_USER CLSUSER = new BL.CLS_USER();
                DataTable dt = new DataTable();
                dt = CLSUSER.login(txt_user.Text, txt_password.Text);
                if (dt.Rows.Count > 0)
                {
                    CLSUSER.updateLogin(txt_user.Text, txt_password.Text);
                    PL.FRM_MAIN FRMMAIN = new PL.FRM_MAIN();
                    object lbname = dt.Rows[0]["CNAME"];
                    object lbprem = dt.Rows[0]["CPERM"];
                    FRMMAIN.lb_name.Text= lbname.ToString();
                    FRMMAIN.lb_prem.Text = lbprem.ToString();
                    FRMMAIN.Show();
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("خطأ في معلومات تسجيل الدخول");
                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}

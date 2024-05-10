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
    public partial class FRM_START : Form
    {
        public FRM_START()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BL.CLS_USER userfrm = new BL.CLS_USER();
            DataTable dt = new DataTable();
            dt = userfrm.STARTLOADDATA();
            if(dt.Rows.Count > 0 )
            {
                PL.FRM_MAIN FRMMAIN = new PL.FRM_MAIN();
                object lbname = dt.Rows[0]["CNAME"];
                object lbprem = dt.Rows[0]["CPERM"];
                FRMMAIN.lb_name.Text = lbname.ToString();
                FRMMAIN.lb_prem.Text = lbprem.ToString();
                FRMMAIN.Show();
                this.Hide();

            }
            else
            {
                PL.FRM_LOGIN FRMLOGIN = new PL.FRM_LOGIN();
                FRMLOGIN.Show();
                this.Hide();





            }
     }
    }
}

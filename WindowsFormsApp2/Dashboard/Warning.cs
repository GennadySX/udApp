using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Dashboard
{
    public partial class Warning : UserControl
    {
       
        public Warning(warningForm form)
        {
            InitializeComponent();
          
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            Dashboardxs xc = new Dashboardxs("aa");
            Profile nn = new Profile("",xc);
          
   
         
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

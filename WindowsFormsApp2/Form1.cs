using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
      
        public bool form_move;
        public Point form_point;
       

        public MainForm()
        {
            

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 20, 20));

           
        }
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
      

        private void MainForm_Load(object sender, EventArgs e)
        {



            Login log = new Login(this);
            logMain_panel.Controls.Clear();
            logMain_panel.Controls.Add(log);

           

           // Dashboardxs nn = new Dashboardxs();
          //  nn.Show();

            GraphicsPath path = new GraphicsPath();
          //  path.AddEllipse(-5, 0, fullScreen_btn.Width, fullScreen_btn.Height);
         // fullScreen_btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, fullScreen_btn.Width, fullScreen_btn.Height, 0, 0)); 
        }

        /* 
        *   Изменение нахождения формы через нажатие мыша
        * *
        * *
        */

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            form_move = true;
            form_point = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(form_move)
            {
                this.Location = new Point(
                    (this.Location.X - form_point.X) + e.X, (this.Location.Y - form_point.Y) + e.Y);
                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            form_move = false;

        }
        private void logMain_panel_MouseDown(object sender, MouseEventArgs e)
        {
            form_move = true;
            form_point = e.Location;
        }

        private void logMain_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (form_move)
            {
                this.Location = new Point(
                    (this.Location.X - form_point.X) + e.X, (this.Location.Y - form_point.Y) + e.Y);
                this.Update();
            }
        }

        private void logMain_panel_MouseUp(object sender, MouseEventArgs e)
        {
            form_move = false;
        }

        //Отсюда уже начнется лаба сама

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        //а отсюда хрены 
        public void minimze_btn_Click(object sender, EventArgs e)
        {
            logMain_panel.Controls.Clear();
            logMain_panel.Controls.Add(new reg_panel(this));
        }

        public void fullScreen_btn_Click(object sender, EventArgs e)
        {

            logMain_panel.Controls.Clear();
            logMain_panel.Controls.Add(new Login(this));
        }

        private void logMain_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

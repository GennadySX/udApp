using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using WindowsFormsApp2.Dashboard;

namespace WindowsFormsApp2
{
    public partial class Dashboardxs : Form
    {


        string bax="";

        public bool windowMove;
        public Point mover;
        public Dashboardxs(string ba)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 20, 20));
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(home);
            bax = ba;
        }
        Home home = new Home();
        organization org = new organization();
        Students student = new Students();
        Schelude rasp = new Schelude();
       
        Masters master = new Masters();
        Materials material = new Materials();
        NewStudent nstudent = new NewStudent();
        //Profile profile = new Profile(bax);
        Support supp = new Support();
        About about = new About();


        //Moving Window
        public void moveMouseDown(object sender, MouseEventArgs e)
        {
            windowMove = true;
            mover = e.Location;
        }

        public void moveMouseMove(object sender, MouseEventArgs e)
        {
            if (windowMove)
            {
                this.Location = new Point(
                    (this.Location.X - mover.X) + e.X, (this.Location.Y - mover.Y) + e.Y);
                this.Update();
            }
        }

        public void moveMouseUp(object sender, MouseEventArgs e)
        {
            windowMove = false;

        }

        //End Moving Window






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


        private void Dashboard_Load(object sender, EventArgs e)
        {
            int non = new Core().ogo(bax);

            // MessageBox.Show(name);

            using (SqlConnection myConnection = new SqlConnection(new Core().cdb))
            {
                string oString = "Select * from users where id=@fName";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Fname", bax);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                       

                        using (SqlConnection connection = new SqlConnection(new Core().cdb))
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            connection.Open();
                            try
                            {
                                SqlCommand comma = new SqlCommand("select image from users where id='" + bax + "'", connection);

                                SqlDataAdapter da = new SqlDataAdapter(comma);

                                DataSet ds = new DataSet();

                                da.Fill(ds);

                                if (ds.Tables[0].Rows.Count > 0)
                                {


                                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                                    user_img.Image = new Bitmap(ms);
                                    ms.Close();

                                }
                            }
                            catch (SqlException exs) { }

                            command.Dispose();

                            connection.Close();

                            connection.Dispose();
                        }
                    }


                    myConnection.Close();
                }
            }

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            int non = new Core().ogo(bax);
            if (non == 0)
            {
                this.contentPanel.Controls.Clear();
                contentPanel.Controls.Add(student);
            }
            else MessageBox.Show("Упс! доступ вам запрешен!");

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fullScreen_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moveMouseDown(sender, e);

        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            moveMouseMove(sender, e);

        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moveMouseUp(sender, e);
        }

        private void support_btn_Click(object sender, EventArgs e)
        {
           // Dashboardxs nn = new Dashboardxs();
            this.Hide();
            MainForm n1 = new MainForm();
            n1.Show();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(home);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void master_class_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new MasterClass(bax));
        }

        private void theme_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new Theme(bax));
        }

        private void group_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new Groups(bax));
        }

        private void pupil_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new StudentsX(bax));
        }

        private void schelude_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(rasp);
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new ToRoom(bax));
        }

        private void masters_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(master);
        }

        private void new_student_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(material);
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
        
            contentPanel.Controls.Add(new Profile(bax,this));
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(about);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new Estimate(bax));
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

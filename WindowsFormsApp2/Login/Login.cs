using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.Dashboard;

namespace WindowsFormsApp2
{
    public partial class Login : UserControl
    {

        MainForm mainp = new MainForm();
        SqlConnection scn = new SqlConnection();
        
        
        public Login(MainForm parent)
        {
            InitializeComponent();
            this.mainp = parent;
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mainp.form_move = true;
            mainp.form_point = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainp.form_move)
            {
                this.mainp.Location = new Point(
                    (this.mainp.Location.X - mainp.form_point.X) + e.X, (this.mainp.Location.Y - mainp.form_point.Y) + e.Y);
                this.mainp.Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mainp.form_move = false;
        }

        public void call_regPanel_Click(object sender, EventArgs e)
        {
            this.mainp.minimze_btn_Click(sender, e);
        }

        private void bunifuCustomLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            Login_MouseDown(sender, e);
        }

        private void bunifuCustomLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            Login_MouseMove(sender, e);
        }

        private void bunifuCustomLabel1_MouseUp(object sender, MouseEventArgs e)
        {
            Login_MouseUp(sender, e);
        }


        /// Забытие паролы


        private void forget_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Чтобы востановить пароль, позвоните пожалуйста по этому номеру: 102 ");
        }


        //Логины
        private void login_input_Click(object sender, EventArgs e)
        {
            if (login_input.Text.Contains("Ваш "))
            {
                login_input.Text="";
            }
        }

        private void login_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (login_input.Text.Contains("Ваш "))
            {
                login_input.Text = "";
            }
        }

        private void login_input_OnValueChanged(object sender, EventArgs e)
        {
            if (login_input.Text.Contains("Ваш "))
            {
                login_input.Text = "";
            }
        }
        private void login_input_MouseEnter(object sender, EventArgs e)
        {
            if (login_input.Text.Contains("Ваш "))
            {
                login_input.Text = "";
            }
        }


        private void login_input_Leave(object sender, EventArgs e)
        {
            if (login_input.Text.Contains("Ваш"))
            {
                login_input.Text = "Введите ваш логин правильно";
            }

        }

        /// Паролы
        /// 
        private void password_input_OnValueChanged(object sender, EventArgs e)
        {
            if (password_input.Text == "Ваш пароль")
            {
                password_input.Text = "";
                
            }
            password_input.isPassword = true;
        }

        private void password_input_Click(object sender, EventArgs e)
        {
            if (password_input.Text == "Ваш пароль")
            {
                password_input.Text = "";
               
            }
            password_input.isPassword = true;
        }

        private void password_input_MouseClick(object sender, MouseEventArgs e)
        {
            if (password_input.Text == "Ваш пароль")
            {
                password_input.Text = "";
               
            }
            password_input.isPassword = true;
        }

        private void password_input_Enter(object sender, EventArgs e)
        {
            if (password_input.Text == "Ваш пароль")
            {
                password_input.Text = "";
               
            }
            password_input.isPassword = true;
        }

        private void password_input_Leave(object sender, EventArgs e)
        {
            if (password_input.Text.Contains(" ") || password_input.Text.Contains("Ваш"))
            {
                if (password_input.Text.Length < 1 || password_input.Text == "Ваш пароль")
                {
                    password_input.Text = "Ваш пароль"; password_input.isPassword = false;
                }
            }else
            {
                password_input.isPassword = true;
            }
        }

        public string l_id(string name)
        {

            string id_X, sname;
            id_X = "";
           
            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            {
                string oString = "Select * from users where login=@fName";
                SqlCommand oCmd = new SqlCommand(oString, connection);
                oCmd.Parameters.AddWithValue("@fName", name);
                connection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        id_X = oReader["id"].ToString();
                        sname = oReader["name"].ToString();
                    }

                    connection.Close();
                }
            }
            return id_X;
        }
        //Кнопка
        private void login_btn_Click(object sender, EventArgs e)
        {
            scn.ConnectionString = new Core().cdb;
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from users where login=@usr and password=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", login_input.Text);
            scmd.Parameters.AddWithValue("@pwd", password_input.Text);
            scn.Open();
            if (scmd.ExecuteScalar().ToString() == "1")
            {
                 Dashboardxs nn = new Dashboardxs(l_id(login_input.Text));
                 nn.Show();
                this.mainp.Hide();

               
              // new Core().name = l_id(login_input.Text);
             //   MessageBox.Show(l_id(login_input.Text));

            }else
            {
                MessageBox.Show("Неверный логин или пароль! ");
            }

           
                scn.Close();
        }

        private void password_input_KeyDown(object sender, KeyEventArgs e)
        {
            password_input_OnValueChanged(sender, e);
        }

        private void login_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                login_btn_Click(sender, e);
            }
        }

        private void password_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                login_btn_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

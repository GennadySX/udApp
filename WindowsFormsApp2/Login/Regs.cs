using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Bunifu.Framework.UI;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class reg_panel : UserControl
    {
        MainForm mainp = new MainForm();

        Match match;
        Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Regex age = new Regex(@"^\d+$");

        bool nameb, snameb, emailb, birthb, logb, passb, repassb, pinb;

       
        public void whenEnter(BunifuMaterialTextbox n)
        {   

            if (n.Text.Contains(vash))
            {
                n.Text = "";

            }
        }
        public void whenLeave(BunifuMaterialTextbox c, string non)
        {
            
            int n = c.Text.Length;
            if (c.Text.Contains(vash) || c.Text.Contains(vash.ToLower()))
            {
                c.Text = non;
              //  check = false;
            }

            if (string.IsNullOrEmpty(c.Text))
            {
                c.Text = non;
               // check = false;
            }
            if (n < 4)
            {
                c.Text = non;
              //  check = false;
            }
          
        }


            //Изменение нахождения

            private void reg_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mainp.form_move = true;
            mainp.form_point = e.Location;

        }

        private void reg_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainp.form_move)
            {
                this.mainp.Location = new Point(
                    (this.mainp.Location.X - mainp.form_point.X) + e.X, (this.mainp.Location.Y - mainp.form_point.Y) + e.Y);
                this.mainp.Update();
            }
        }

        private void reg_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mainp.form_move = false;
        }



        public reg_panel(MainForm parent)
        {
            InitializeComponent();
            this.mainp = parent;
        }


        private void reb_backToLogin_Click(object sender, EventArgs e)
        {

            this.mainp.fullScreen_btn_Click(sender, e);
        }

        private void reg_email_OnValueChanged(object sender, EventArgs e)
        {
            if (reg_email.Text.Contains("ваш email"))
            {
                whenEnter(reg_email);
            }
        }
        string vash ="Ваш";

        //Имя
        private void reg_fname_KeyDown(object sender, KeyEventArgs e)
        {
            whenEnter(reg_fname);
        }
        private void reg_fname_Leave(object sender, EventArgs e)
        {
         
            whenLeave(reg_fname, "Ваше имя");

            if (!reg_fname.Text.Contains("Ваше"))
            {
                nameb = true;
            }
        }

        private void reg_fname_MouseLeave(object sender, EventArgs e)
        {
        
            reg_fname_Leave(sender, e);
          
        }

        // Фамилия      
        private void reg_sname_KeyDown(object sender, KeyEventArgs e)
        {
            whenEnter(reg_sname);

        }
      

        private void reg_sname_Leave(object sender, EventArgs e)
        {
            whenLeave(reg_sname, "Ваша фамилия");
            if (!reg_sname.Text.Contains("Ваша"))
            {
                snameb = true;
            }
        }
        private void reg_sname_MouseLeave(object sender, EventArgs e)
        {
            reg_sname_Leave(sender, e);
        }
        //
        //Email
        private void reg_email_KeyDown(object sender, KeyEventArgs e)
        {
           // whenEnter(reg_email);
           
        }

        private void reg_email_Leave(object sender, EventArgs e)
        {
           
            match = email.Match(reg_email.Text);
            if (!match.Success) { reg_email.Text = "Ваш email"; emailb = false; }
            else emailb = true;
        }

        //Возраст

        private void reg_age_MouseLeave(object sender, EventArgs e)
        {
            reg_email_Leave(sender, e);
        }
        private void reg_age_Leave(object sender, EventArgs e)
        {

            match = age.Match(reg_age.Text);
            if (!match.Success) { birthb = false; }
            else birthb = true;
        
        }

        private void reg_age_Click(object sender, EventArgs e)
        {
            date_btn.Show();
        }

        private void date_btn_Click(object sender, EventArgs e)
        {

        }

        private void date_btn_onValueChanged(object sender, EventArgs e)
        {
            string mon;
            DateTime dt = this.date_btn.Value.Date;
            mon = dt.Month.ToString();
            if (dt.Month < 10) mon  = "0" + dt.Month.ToString(); 
            reg_age.Text = dt.Day + "." +mon + "." + dt.Year;
            birthb = true;
        }

        //логин
        private void reg_login_KeyDown(object sender, KeyEventArgs e)
        {
            whenEnter(reg_login);
        }
        private void reg_login_Leave(object sender, EventArgs e)
        {
            whenLeave(reg_login, "Ваш логин");
            if (reg_login.Text.Contains("Ваш")) { logb = false; }
            else logb = true;
        }
        private void reg_login_MouseLeave(object sender, EventArgs e)
        {
            reg_login_Leave(sender, e);
        }
        //

        private void reg_pass_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void reg_pass_Leave(object sender, EventArgs e)
        {
            whenLeave(reg_pass, "Ваш пароль");
            if(reg_pass.Text.Contains("Ваш"))
            {
                passb = false;
                reg_pass.isPassword = false;
            } else
            {
                passb = true;
            }
        }

        private void reg_pass_MouseLeave(object sender, EventArgs e)
        {
            reg_pass_Leave(sender, e);
        }

        private void reg_reg_btn_Click(object sender, EventArgs e)
        {

            if (reg_checkbox.Checked == true)
            {

                using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {
                    string no = "";
                    string nx = "";
                    connection.Open();

                    command.CommandText = "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image)  VALUES (@name,@sname, @email,@date,@log,@pass,@pin,@role,@img) ";
                       // "INSERT INTO [dbo].[users] ( [name], [surname], [email], [birth_date], [login], [password], [secret_code], [role]" + no + ") VALUES (@name,@sname, @email,@date,@log,@pass,@pin,@role" + nx + ")";
                    //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";

                    command.Parameters.Add(new SqlParameter("@name", reg_fname.Text));
                    command.Parameters.Add(new SqlParameter("@sname", reg_sname.Text));
                    command.Parameters.Add(new SqlParameter("@email", reg_email.Text));
                    command.Parameters.Add(new SqlParameter("@date", reg_age.Text));
                    command.Parameters.Add(new SqlParameter("@log", reg_login.Text));
                    command.Parameters.Add(new SqlParameter("@pass", reg_pass.Text));
                    command.Parameters.Add(new SqlParameter("@pin", reg_secretPin.Text));
                    command.Parameters.Add(new SqlParameter("@role", 2));

                    try
                    {
                        byte[] fileBytes = System.IO.File.ReadAllBytes("C:\\dev\\image.jpg");
                       
                        command.Parameters.AddWithValue("@img", fileBytes);
                      

                        /*    MemoryStream ms = new MemoryStream();
                            imageUT.Image.Save(ms, ImageFormat.Jpeg);
                            byte[] photo_aray = new byte[System.Convert.ToInt32(ms.Length)]; //Byte[] photo_aray = new Byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(photo_aray, 0, System.Convert.ToInt32(photo_aray.Length));
                            ms.Close();
                            // command.Parameters.AddWithValue("@img", photo_aray);
                            command.Parameters.Add(new SqlParameter("@img", photo_aray));
                        
    */

                        command.ExecuteNonQuery();
                        this.mainp.fullScreen_btn_Click(sender, e);
                        
                      
                    } catch (Exception es) { MessageBox.Show("Неправильно введены данные!"); }
                    command.Dispose();

                    connection.Close();

                    connection.Dispose();

                }


                
            }
        }


       


        private void reg_repass_Enter(object sender, EventArgs e)
        {
            if (reg_repass.Text.Contains("пароль"))
            {
                reg_repass.Text = "";
            }
            reg_repass.isPassword = true;
        }

        private void reg_pass_Enter(object sender, EventArgs e)
        {
            whenEnter(reg_pass);
            reg_pass.isPassword = true;
        }

        private void reg_rule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg_checkbox.Checked = false;
        }

        private void reg_age_Enter(object sender, EventArgs e)
        {
            date_btn_onValueChanged(sender, e);
        }

        private void reg_email_Enter(object sender, EventArgs e)
        {
            if (reg_email.Text == "" || reg_email.Text.Contains("ваш email") || reg_email.Text.Contains("Ваш email"))
            {
                whenEnter(reg_email);
            }
        }



        //

        private void reg_repass_KeyDown(object sender, KeyEventArgs e)
        {
           
        
        }

        private void reg_repass_Leave(object sender, EventArgs e)
        {
            if(reg_pass.Text != reg_repass.Text)
            {
                whenLeave(reg_repass, "Повторите пароль");
                reg_repass.isPassword = false; repassb = false;

            }
            else
            {
                repassb = true;
            }
        }

        private void reg_repass_MouseLeave(object sender, EventArgs e)
        {
            reg_repass_Leave(sender, e);
            repassb = true;
        }
        //

        private void reg_secretPin_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (reg_secretPin.Text.Contains("Секретный") || reg_secretPin.Text.Contains("Введите"))
            {
                reg_secretPin.Text = "";
            }
        }

        private void reg_secretPin_Leave(object sender, EventArgs e)
        {
            pinb = true;
            match = age.Match(reg_secretPin.Text);
            if (!match.Success)
            {
                reg_secretPin.Text = "Введите только по цифрам!";
                pinb = false;
            } else
            {
                pinb = true;
            }
        }

        private void reg_secretPin_MouseLeave(object sender, EventArgs e)
        {
            reg_secretPin_Leave(sender, e);
        }

        private void reg_checkbox_OnChange(object sender, EventArgs e)
        {

            if (nameb && snameb && emailb && birthb && logb && passb && repassb && pinb) reg_checkbox.Checked = true;
            else reg_checkbox.Checked = false;

            if (!nameb) MessageBox.Show("Не правильно введено имени поля!");
            if (!snameb) MessageBox.Show("Не правильно введена поля фамилии!");
            if (!emailb) MessageBox.Show("Не правильно введено поля адрес почты!");
            if (!birthb) MessageBox.Show("Не правильно введено поля день рождения!");
            if (!logb) MessageBox.Show("Не правильно введено поля логина!");
            if (!passb) MessageBox.Show("Не правильно введено поля пароля 1!");
            if (!repassb) MessageBox.Show("Не совпадения пароли!");
            if (!pinb) MessageBox.Show("Не правильно введено поля серкетного ключа!");
            
        }

        //









    }
}

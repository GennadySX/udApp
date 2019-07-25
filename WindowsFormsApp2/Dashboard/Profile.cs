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
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApp2.Dashboard
{
    
    public partial class Profile : UserControl
    {
        string name;
        int idEr = 2;
        Dashboardxs org;
        Core core = new Core();
        //warningForm wx = new warningForm(this);


        public Profile(string namex,Dashboardxs child)
        {
            InitializeComponent();
            name = namex;
            this.org = child;
           // idEr = Int32.Parse(id_x);
        }

   
     
        private void Profile_Load(object sender, EventArgs e)
        {
            int non = new Core().ogo(name);
            if (non != 0) roleUT.Enabled = false;

                // MessageBox.Show(name);

                using (SqlConnection myConnection = new SqlConnection(new Core().cdb))
            {
                string oString = "Select * from users where id=@fName";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Fname", name);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        nameUT.Text = oReader["name"].ToString();
                        surnameUT.Text = oReader["surname"].ToString();
                        emailUT.Text = oReader["email"].ToString();
                        birthUT.Text = oReader["birth_date"].ToString();
                        loginUT.Text = oReader["login"].ToString();
                        passUT.Text = oReader["password"].ToString();
                        pinUT.Text = oReader["secret_code"].ToString();
                        roleUT.selectedIndex = Int32.Parse(oReader["role"].ToString());
                        string ss = oReader["image"].ToString();
                       
                             using (SqlConnection connection = new SqlConnection(new Core().cdb))
                             using (SqlCommand command = connection.CreateCommand())
                             {
                                 connection.Open();
                                 try
                                 {
                                     SqlCommand comma = new SqlCommand("select image from users where id='" + name + "'", connection);

                                     SqlDataAdapter da = new SqlDataAdapter(comma);

                                     DataSet ds = new DataSet();

                                     da.Fill(ds);

                                     if (ds.Tables[0].Rows.Count > 0)
                                     {


                                         MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                                         imageUT.Image = new Bitmap(ms);
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            string[] col = new string[8] { "name", "surname", "email", "birth_date", "login", "password", "secret_code", "role" };
            string[] values = new string[8] { nameUT.Text, surnameUT.Text, emailUT.Text, birthUT.Text, loginUT.Text, passUT.Text, pinUT.Text, roleUT.selectedIndex.ToString() };

            core.updateDB("users", col, values, "", name);

            /*
            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            using (SqlCommand command = connection.CreateCommand())
            {

                connection.Open();
              
                    command.CommandText = "update users set  name=@name , surname=@surname, email=@email,birth_date=@birth_date, login=@login, password=@password,secret_code=@secret_code , role=@role  where id=@id";

                    command.Parameters.Add(new SqlParameter("@id", name));


                //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                command.Parameters.Add(new SqlParameter("@name", nameUT.Text));
                command.Parameters.Add(new SqlParameter("@surname", surnameUT.Text));
                command.Parameters.Add(new SqlParameter("@email", emailUT.Text));
                command.Parameters.Add(new SqlParameter("@birth_date", birthUT.Text));
                command.Parameters.Add(new SqlParameter("@login", loginUT.Text));
                command.Parameters.Add(new SqlParameter("@password", passUT.Text));
                command.Parameters.Add(new SqlParameter("@secret_code", pinUT.Text));
                command.Parameters.Add(new SqlParameter("@role", roleUT.selectedIndex.ToString()));
                   try
                {
                    command.ExecuteNonQuery();
                    // MessageXS xs = new MessageXS();
                    //xs.Show();
                    MessageBox.Show("Операция выполнена успешно");
                }
                catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                command.Dispose();

                connection.Close();

                connection.Dispose();


            }*/
        }

        
        private void deleteB_Click(object sender, EventArgs e)
        {
            warningForm ss = new warningForm(name,org);
            ss.Show();

         
          }

        private void call_regPanel_Click(object sender, EventArgs e)
        {
            if (dialogFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialogFile.FileName);
                imageUT.Image = new Bitmap(dialogFile.FileName);
                this.org.user_img.Image = new Bitmap(dialogFile.FileName);


            }

            dialogFile.Filter = "Файлы jpeg|*.jpeg|Файлы jpg|*.jpg";
           

            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            using (SqlCommand command = connection.CreateCommand())
            {

                connection.Open();

                command.CommandText = "update users set  name=@name , surname=@surname, email=@email,birth_date=@birth_date, login=@login, password=@password,secret_code=@secret_code , role=@role ,image=@img where id=@id";

                command.Parameters.Add(new SqlParameter("@id", name));


                //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                command.Parameters.Add(new SqlParameter("@name", nameUT.Text));
                command.Parameters.Add(new SqlParameter("@surname", surnameUT.Text));
                command.Parameters.Add(new SqlParameter("@email", emailUT.Text));
                command.Parameters.Add(new SqlParameter("@birth_date", birthUT.Text));
                command.Parameters.Add(new SqlParameter("@login", loginUT.Text));
                command.Parameters.Add(new SqlParameter("@password", passUT.Text));
                command.Parameters.Add(new SqlParameter("@secret_code", pinUT.Text));
                command.Parameters.Add(new SqlParameter("@role", roleUT.selectedIndex.ToString()));

                try
                {
                    
                        MemoryStream ms = new MemoryStream();
                        imageUT.Image.Save(ms, ImageFormat.Jpeg);
                        
                        byte[] photo_aray = new byte[System.Convert.ToInt32(ms.Length)]; //Byte[] photo_aray = new Byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(photo_aray, 0, System.Convert.ToInt32(photo_aray.Length));
                        ms.Close();
                        // command.Parameters.AddWithValue("@img", photo_aray);
                        command.Parameters.Add(new SqlParameter("@img", photo_aray));
                   
                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT id FROM users WHERE id=" + name+ "";

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        string nn = (dr["id"]).ToString();
                        MessageBox.Show("Updated item " + nn);
                    }
                    dr.Close();
                    ((IDisposable)dr).Dispose();//always good idea to do proper cleanup
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.ToString());
                }

               
                command.Dispose();

                connection.Close();

                connection.Dispose();


            }
        }

        private void imageUT_Click(object sender, EventArgs e)
        {

        }

        private void birthUT_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void date_btn_onValueChanged(object sender, EventArgs e)
        {

            string mon;
            DateTime dt = this.date_btn.Value.Date;
            mon = dt.Month.ToString();
            if (dt.Month < 10) mon = "0" + dt.Month.ToString();
            birthUT.Text = dt.Day + "." + mon + "." + dt.Year;

        }

        private void birthUT_Enter(object sender, EventArgs e)
        {
            date_btn_onValueChanged(sender, e);
        }
    }
    }


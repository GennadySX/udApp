using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace WindowsFormsApp2
{
    public partial class Students : UserControl
    {
        MemoryStream ms;
        byte[] photo_aray;
        DataSet ds;
        SqlConnection connection = new SqlConnection(new Core().cdb);
        SqlCommand command;
        bool opened =false;

        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            this.usersAdapter.Fill(this.udDataSet.users);
        }

        private void userGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idUT.Text = userGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameUT.Text = userGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            surnameUT.Text = userGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailUT.Text = userGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            birthUT.Text = userGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            loginUT.Text = userGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            passUT.Text = userGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            pinUT.Text = userGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            int n=2;

            try
            {
                 n = Int32.Parse(userGrid.Rows[e.RowIndex].Cells[8].Value.ToString());
            }catch(Exception ex)
            {

            }
            switch(n)
            {
                case 0:
                    roleUT.selectedIndex = 0;
                    break;

                case 1:
                    roleUT.selectedIndex = 1;
                    break;
                case 2:
                    roleUT.selectedIndex = 2;
                    break;
                case 3:
                    roleUT.selectedIndex = 1;
                    break;
                case 4:
                    roleUT.selectedIndex = 1;
                    break;
                default:
                    roleUT.selectedIndex = 1;
                    break;

            }
            if (userGrid.Rows[e.RowIndex].Cells[7].Value != System.DBNull.Value)
            {
                using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    try
                    {
                        SqlCommand comma = new SqlCommand("select image from users where id='" + userGrid.Rows[e.RowIndex].Cells[0].Value + "'", connection);

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
        }
       


        public void nns(int n)
        {
           
        }



        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
           
         
        }

        private void imageUT_Click(object sender, EventArgs e)
        {
            if (dialogFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialogFile.FileName);
                imageUT.Image = new Bitmap(dialogFile.FileName);
            }
            
            dialogFile.Filter = "Файлы jpeg|*.jpeg|Файлы jpg|*.jpg";
            opened = true;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
        }



        private void clear_btn_Click(object sender, EventArgs e)
        {
           

        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open(); //DELETE FROM Customers WHERE CustomerName = 'Alfreds Futterkiste';

                command.CommandText = "DELETE FROM users WHERE name=@name and login=@log";
                command.Parameters.Add(new SqlParameter("@name", nameUT.Text));
                command.Parameters.Add(new SqlParameter("@log", loginUT.Text));
                command.ExecuteNonQuery();
                this.usersAdapter.Fill(this.udDataSet.users);

                connection.Close();
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {

            
            /*
            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            using (SqlCommand command = connection.CreateCommand())
            {
                string no = ", [image]";
                string nx = ",@img";
                connection.Open();
                if(!opened)
                {
                    no = "";
                    nx = "";
                }
                command.CommandText = "INSERT INTO [dbo].[users] ([id], [name], [surname], [email], [birth_date], [login], [password], [secret_code], [role]"+no+") VALUES (@id,@name,@sname, @email,@date,@log,@pass,@pin,@role"+nx+")";
                //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                command.Parameters.Add(new SqlParameter("@id", idUT.Text));
                command.Parameters.Add(new SqlParameter("@name", nameUT.Text));
                command.Parameters.Add(new SqlParameter("@sname", surnameUT.Text));
                command.Parameters.Add(new SqlParameter("@email", emailUT.Text));
                command.Parameters.Add(new SqlParameter("@date", birthUT.Text));
                command.Parameters.Add(new SqlParameter("@log", loginUT.Text));
                command.Parameters.Add(new SqlParameter("@pass", passUT.Text));
                command.Parameters.Add(new SqlParameter("@pin", pinUT.Text));
                command.Parameters.Add(new SqlParameter("@role", roleUT.selectedIndex));

                if (opened)
                {
                    if (imageUT.Image != null)
                    {
                        //using FileStream:(will not work while updating, if image is not changed)
                        //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        //byte[] photo_aray = new byte[fs.Length];
                        //fs.Read(photo_aray, 0, photo_aray.Length);  

                        //using MemoryStream:
                        MemoryStream ms = new MemoryStream();
                        imageUT.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] photo_aray = new byte[System.Convert.ToInt32(ms.Length)]; //Byte[] photo_aray = new Byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(photo_aray, 0, System.Convert.ToInt32(photo_aray.Length));
                        ms.Close();
                        command.Parameters.AddWithValue("@img", photo_aray);// command.Parameters.Add(new SqlParameter("@img", photo_aray)); //* 
                    }
                }
                try
                {


                    command.ExecuteNonQuery();
                        this.usersAdapter.Fill(this.udDataSet.users);
                        MessageBox.Show("ok");

                }
                catch (Exception es) { MessageBox.Show("oops"); }
                command.Dispose();

                connection.Close();

                connection.Dispose();


           
        }*/

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            using (SqlCommand command = connection.CreateCommand())
            {
                string no = ", [image]";
                string nx = ", image=@img where id=";
                connection.Open();  //Insert into Izdelie(name, color, image, quantity,width,lenght,cost) values (@name,@color, @image,@quantity,@width,@lenght,@cost)
                if (!opened)
                {
                    no = "";
                    nx = "";
                }
                if (imageUT.Image != null){
                
                    
                  
                    command.CommandText = "Update users Set  name=@name, surname=@sname,email=@mail,birth_date=@date,login=@log, password=@password,secret_code=@pin, role=@role"+nx + idUT.Text + "";
                    command.Parameters.Add(new SqlParameter("@name", nameUT.Text));
                    command.Parameters.Add(new SqlParameter("@sname", surnameUT.Text));
                    command.Parameters.Add(new SqlParameter("@mail", emailUT.Text));
                    command.Parameters.Add(new SqlParameter("@date", birthUT.Text));
                    command.Parameters.Add(new SqlParameter("@log", loginUT.Text));
                    command.Parameters.Add(new SqlParameter("@password", passUT.Text));
                    command.Parameters.Add(new SqlParameter("@pin", pinUT.Text));
                    command.Parameters.Add(new SqlParameter("@role", roleUT.selectedIndex));
                   
                }
              try
                {
                    if (opened)
                    {
                        MemoryStream ms = new MemoryStream();
                        imageUT.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] photo_aray = new byte[System.Convert.ToInt32(ms.Length)]; //Byte[] photo_aray = new Byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(photo_aray, 0, System.Convert.ToInt32(photo_aray.Length));
                        ms.Close();
                        // command.Parameters.AddWithValue("@img", photo_aray);
                        command.Parameters.Add(new SqlParameter("@img", photo_aray));
                    }
                    command.ExecuteNonQuery();
                
                    command.CommandText = "SELECT id FROM users WHERE id=" +idUT.Text + "";

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        string nn = (dr["id"]).ToString();
                        MessageBox.Show("Updated item " + nn);
                        this.usersAdapter.Fill(this.udDataSet.users);
                    }
                    dr.Close();
                    ((IDisposable)dr).Dispose();//always good idea to do proper cleanup
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.ToString());
                }


                connection.Close();
                connection.Dispose();
            }
        }
    }
}

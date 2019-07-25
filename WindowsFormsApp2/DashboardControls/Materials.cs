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
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsApp2.Dashboard
{
    public partial class Materials : UserControl
    {
        public Materials()
        {
            InitializeComponent();
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dialogFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialogFile.FileName);
             //   imageUT.Image = new Bitmap(dialogFile.FileName);
            }

            dialogFile.Filter = "Файлы jpeg|*.jpeg|Файлы jpg|*.jpg";
        }

        private void upload_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = "INSERT INTO img ( [image]) VALUES (@img)";
                
                
               // command.CommandText = "INSERT INTO [dbo].[img] ([id], [image]) VALUES (@id,@img)";
               // command.Parameters.Add(new SqlParameter("@id", "11"));
              //  if (imageUT.Image != null)
               // {
                    //using FileStream:(will not work while updating, if image is not changed)
                    //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    //byte[] photo_aray = new byte[fs.Length];
                    //fs.Read(photo_aray, 0, photo_aray.Length);  

                    //using MemoryStream:
                    MemoryStream ms = new MemoryStream();
                 //   imageUT.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] photo_aray = new byte[System.Convert.ToInt32(ms.Length)]; //Byte[] photo_aray = new Byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, System.Convert.ToInt32(photo_aray.Length));
                    ms.Close();
                  command.Parameters.AddWithValue("@img", photo_aray);// command.Parameters.Add(new SqlParameter("@img", photo_aray)); //* 
              //  }
                try
                {
                  

                    command.ExecuteNonQuery();
                 //   command.ExecuteNonQuery();
                   
                    MessageBox.Show("ok");

                }
                catch (Exception es) { MessageBox.Show("oops"); }
                command.Dispose();

                connection.Close();

                connection.Dispose();

                
            }
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
            {
                
                
                SqlCommand cmd = new SqlCommand("select image from img where id='" + 1 + "'", connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)

                    {

                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);

                      //  imageUT.Image = new Bitmap(ms);
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
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Core
    {
        public string cdb = @"Data Source=DESKTOP-CISH18A\SQLEXPRESS;Initial Catalog=login_database;database=UD;integrated security=SSPI";
        // @"Data Source=DESKTOP-CISH18A\SQLEXPRESS;Initial Catalog=UD;Integrated Security=True";
        public string name = "";

        int nna;


        public void insertDB(string tableName, string[] columns, string[] values, string linkImg)
        {
            byte[] photo_aray;
            string comma = ", ";
            string[] val = new string[columns.Length];

            string nx = "Insert into " + tableName + "( ";


            using (SqlConnection connection = new SqlConnection(cdb))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                for (int i = 0; i < columns.Length; i++)
                {
                    if (i == columns.GetUpperBound(0))
                    {
                        if (columns[columns.GetUpperBound(0)].Contains("img") && linkImg == null)
                        {
                            if (linkImg == "")
                            {
                                nx += "";
                                val[i] = "";
                            }
                        }
                        else
                        {
                            nx += columns[i];
                            val[i] = "@" + columns[i];
                        }


                        nx += ")  VALUES (";
                        foreach (string valx in val)
                        {
                            nx += valx;
                        }
                        nx += ") ";
                    }
                    else
                    {
                        nx += columns[i] + comma;
                        val[i] = "@" + columns[i] + comma;
                    }

                }

                command.CommandText = nx;

                for (int i = 0; i < columns.Length; i++)
                {
                    command.Parameters.AddWithValue(val[i], values[i]);
                    if (columns.GetUpperBound(0) == i)
                    {
                        if (linkImg != null)
                        {
                            if (linkImg != "")
                            {
                                try
                                {
                                    MemoryStream ms = new MemoryStream();
                                    Image nm = Image.FromFile(linkImg);
                                    nm.Save(ms, ImageFormat.Jpeg);
                                    photo_aray = new byte[System.Convert.ToInt32(ms.Length)]; //Byte[] photo_aray = new Byte[ms.Length];
                                    ms.Position = 0;
                                    ms.Read(photo_aray, 0, System.Convert.ToInt32(photo_aray.Length));
                                    ms.Close();
                                    // command.Parameters.AddWithValue("@img", photo_aray);

                                    command.Parameters.AddWithValue(val[columns.GetUpperBound(0)], photo_aray);
                                }
                                catch (BadImageFormatException x)
                                {
                                    MessageBox.Show(x.ToString());

                                }
                            }
                        }
                    }

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Операция выполнена успешно!");
                    }
                    catch (Exception es) { MessageBox.Show("Неправильно введены данные!"); }

                    command.Dispose();
                    connection.Close();
                    connection.Dispose();

                }
            }
        }

        public void updateDB(string tableName, string[] columns, string[] values, string linkImg,string id)
        {
            byte[] photo_aray;
            string comma = " , ";
            string[] val = new string[columns.Length];
            
            string nx = "Update " + tableName + " Set ";
            string xnc="";

            using (SqlConnection connection = new SqlConnection(cdb))
            using (SqlCommand command = connection.CreateCommand())
            {

                connection.Open();
                command.CommandType = System.Data.CommandType.Text;

              for (int i = 0; i < columns.Length; i++)
                {
                    if (i == columns.GetUpperBound(0))
                    {
                        val[i] = "@" + columns[i] + "";
                        nx += columns[i] + "=" + val[i];
                        xnc += i+" " +values[i] + " \n";
                    }
                    else
                    {
                        val[i] = "@" + columns[i];
                        nx += columns[i] +"="+ val[i]+comma;
                        xnc += i + " " + values[i] + "\n "; 
                    }

                    if (i == columns.GetUpperBound(0))
                    {
                        nx += "  WHERE ";

                        nx += "id=" +id+"";


                    }
                }
                
                command.CommandText = nx;

                command.Parameters.AddWithValue("@id", id);
                for (int i = 0; i < columns.Length; i++)
                {
                    command.Parameters.AddWithValue(val[i], values[i]);
                    
                    if (columns.GetUpperBound(0) == i)
                    {
                        if (linkImg != null)
                        {
                            if (linkImg != "")
                            {
                                try
                                {
                                    MemoryStream ms = new MemoryStream();
                                    Image nm = Image.FromFile(linkImg);
                                    nm.Save(ms, ImageFormat.Jpeg);
                                    photo_aray = new byte[System.Convert.ToInt32(ms.Length)]; //Byte[] photo_aray = new Byte[ms.Length];
                                    ms.Position = 0;
                                    ms.Read(photo_aray, 0, System.Convert.ToInt32(photo_aray.Length));
                                    ms.Close();
                                    // command.Parameters.AddWithValue("@img", photo_aray);

                                    command.Parameters.Add(new SqlParameter(val[columns.GetUpperBound(0)], photo_aray));
                                }
                                catch (BadImageFormatException x)
                                {
                                    MessageBox.Show(x.ToString());

                                }
                            }
                        }
                    }

                }

                try
                {
                    var exe = command.ExecuteNonQuery();
                    if (exe == 1)
                    {
                        MessageBox.Show("Операция выполнена успешно!");
                    } else
                    {
                        MessageBox.Show("Неправильно введены данные! " + nx);
                    }
                    
                }
                catch (SqlException es)
                {
                 //   MessageBox.Show("Неправильно введены данные! " +xnc);
                  MessageBox.Show(es.ToString());
                }

                    command.Dispose();
                    connection.Close();
                    connection.Dispose();

             
            }

        }

        public void deleteDB(string tableName, string[] columns, string[] values, string linkImg)
        {

            string comma = ", ";
            string[] val = new string[columns.Length];

            string nx = "DELETE FROM " + tableName + "";

            using (SqlConnection connection = new SqlConnection(cdb))
            using (SqlCommand command = connection.CreateCommand())
            {

                connection.Open();
                for (int i = 0; i < columns.Length; i++)
                {
                    if (i == columns.GetUpperBound(0))
                    {
                        val[i] = "@" + columns[i] + "";
                        nx += columns[i]+"=" + val[i];

                    }
                    else
                    {
                        val[i] = "@" + columns[i] + comma;
                        nx += columns[i]+"=" + val[i];

                    }

                    if (i == columns.GetUpperBound(0))
                    {
                        nx += "  WHERE ";

                        nx += columns[0] + "=" + values[0] + " and " + columns[2] + "=" + values[2] + "";


                    }
                }
                command.CommandText = nx;





                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Операция выполнена успешно!");
                }
                catch (Exception es) { MessageBox.Show("Неправильно введены данные!"); }

                command.Dispose();
                connection.Close();
                connection.Dispose();

            }
        }




        public int ogo(string id)
        {
            using (SqlConnection myConnection = new SqlConnection(new Core().cdb))
            {
                string oString = "Select * from users where id=@fName";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Fname", id);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        nna = Int32.Parse(oReader["role"].ToString());

                    }


                    myConnection.Close();
                    myConnection.Dispose();
                }
                return nna;
            }


        }





       

    }

    
    static class Program
    {

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            





        }
    }




    public class Commetsx
    {
        /*  public void insertDB(string table, int count_values, string[] name_cells, string[] get_value)
     {

         string[] name_cell = new string[count_values];



         using (SqlConnection connection = new SqlConnection(new Core().cdb))
         using (SqlCommand command = connection.CreateCommand())
         {

             connection.Open();
             for (int i = 0; count_values > i; i++)
             {
                 if (i == count_values - 1)
                 {
                     name_cell[i] = "[" + name_cells[i] + "]";
                 }
                 else
                 {
                     name_cell[i] = "[" + name_cells[i] + "]" + ", ";
                 }

             }
             string comma = "INSERT INTO " + table + " ( ";
             for (int i = 0; name_cell.Length >= i; i++)
             {
                 comma += name_cell[i];
             }

             comma += ") VALUES (";
             string[] dotcell = new string[name_cell.Length];
             for (int i = 0; name_cells.Length > i; i++)
             {

                 if (i == count_values - 1)
                 {
                     dotcell[i] = "@" + name_cells[i] + "";

                 }
                 else
                 {
                     dotcell[i] = "@" + name_cells[i] + " ,";
                 }
                 comma += dotcell[i];
             }
             comma += ")";
             command.CommandText = comma;

             for (int i = 0; name_cell.Length >= 1; i++)
             {
                 command.Parameters.Add(new SqlParameter(dotcell[i], get_value[i]));
             }
             //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";

             try
             {
                 command.ExecuteNonQuery();
                 //     this.masterClassTableAdapter.Fill(this.udData.masterClass);
                 MessageBox.Show("Вы записались в группу!");
             }
             catch (Exception es) { MessageBox.Show("Что то не так!!!"); }
             command.Dispose();

             connection.Close();

             connection.Dispose();

         }
     }*/

        /*public static void InsertImage(int inventoryID, int businessID, FileInfo file, string sqlConnection)
   {
       /*
       var list = new List<byte>();
       using (var stream = file.Open(FileMode.Open))
       {
           var data = new byte[stream.Length];
           stream.Read(data, 0, data.Length);
           list.AddRange(data);
       }
       var bmp = System.Drawing.Image.FromFile(file.FullName, true);


       using (var conn = new SqlConnection(sqlConnection))
       {
           conn.Open();
           var imageId = -1;
           var sqlSelect = "SELECT [ImageId] FROM [dbo].[ImageTable] WHERE [InventoryId]=@InventoryId;";
           using (var cmd = new SqlCommand(sqlSelect, conn))
           {
               cmd.Parameters.Add("@InventoryId", System.Data.SqlDbType.Int).Value = inventoryID;
               using (var r = cmd.ExecuteReader())
               {
                   if (r.Read())
                   {
                       var o = r["ImageId"];
                       if ((o != null) && (o != DBNull.Value))
                       {
                           imageId = (int)o;
                       }
                   }
               }
           }
           if (imageId == -1)
           {
               var sqlCmd = "INSERT INTO [dbo].[ImageTable] " +
                   "([InventoryId], [ImageFileName], [ImageSize], [ImageWidth], [ImageHeight], [ImageBytes]) " +
                   "VALUES " +
                   "(@InventoryId,  @ImageFileName,  @ImageSize,  @ImageWidth,  @ImageHeight,  @ImageBytes); ";
               using (var cmd = new SqlCommand(sqlCmd, conn))
               {
                   cmd.Parameters.Add("@InventoryId", System.Data.SqlDbType.Int).Value = inventoryID;
                   cmd.Parameters.Add("@ImageFileName", System.Data.SqlDbType.VarChar, 255).Value = file.Name;
                   cmd.Parameters.Add("@ImageSize", System.Data.SqlDbType.Int).Value = list.Count;
                   cmd.Parameters.Add("@ImageWidth", System.Data.SqlDbType.SmallInt).Value = bmp.Width;
                   cmd.Parameters.Add("@ImageHeight", System.Data.SqlDbType.SmallInt).Value = bmp.Height;
                   cmd.Parameters.Add("@ImageBytes", System.Data.SqlDbType.VarBinary, -1).Value = list.ToArray();
                   cmd.ExecuteNonQuery();
               }
           }
       }*/


    }


}

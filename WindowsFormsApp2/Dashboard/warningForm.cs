using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Dashboard
{
    public partial class warningForm : Form
    {
        Profile mn;
        string id;
        Dashboardxs das;
        public warningForm(string name ,Dashboardxs xs)
        {
            InitializeComponent();
            this.id = name;
            this.das = xs;
        }
      

        private void warningForm_Load(object sender, EventArgs e)
        {
          

        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
           
               
                    using (SqlConnection connection = new SqlConnection(new Core().cdb))
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();

                        command.CommandText = "delete from users where id=@id";
                        command.Parameters.Add(new SqlParameter("@id", id));

                        try
                        {
                            command.ExecuteNonQuery();
                            

                        }
                        catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                        command.Dispose();

                        connection.Close();

                        connection.Dispose();

                    }
            this.Hide();
            this.das.Hide();
          MainForm sxxs =  new MainForm();
            sxxs.Show();
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}

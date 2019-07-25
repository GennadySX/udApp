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

namespace WindowsFormsApp2
{
    public partial class Groups : UserControl
    {
        Core isc = new Core();
        string user_id;
        public Groups(string id)
        {
            InitializeComponent();
            user_id = id;
        }
        int nn;
        private void Groups_Load(object sender, EventArgs e)
        {
            int non = new Core().ogo(user_id);
            if (non != 0) groups_grid.ReadOnly = true;
            this.groupsTableAdapter.Fill(this.baseX.groups);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //  MessageBox.Show("ok");
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (groups_grid.Rows[e.RowIndex].Cells[1].Value.ToString() != "" && groups_grid.Rows[e.RowIndex].Cells[2].Value.ToString() != "" && groups_grid.Rows[e.RowIndex].Cells[3].Value.ToString() != "")
            {

                using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {
                   
                    connection.Open();
                    int nax = Int32.Parse(groups_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (nax < 0)
                    {
                        command.CommandText = "INSERT INTO groups ( group_name, master_id, student_id) OUTPUT INSERTED.ID VALUES (@groupname,@master_id,@student_id)";
                      
     
                    }
                    else
                    {
                        command.CommandText = "update groups set  group_name=@groupname , master_id=@master_id , student_id=@student_id  where id=@id";

                        command.Parameters.Add(new SqlParameter("@id", groups_grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    }

                    //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                    command.Parameters.Add(new SqlParameter("@groupname", groups_grid.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@master_id", groups_grid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@student_id", groups_grid.Rows[e.RowIndex].Cells[3].Value.ToString()));

                    try
                    {

                        command.ExecuteNonQuery();
                        this.groupsTableAdapter.Fill(this.baseX.groups);

                      

                    }
                    catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                    command.Dispose();

                    connection.Close();

                    connection.Dispose();


                }
            }
        }


    

        private void groups_grid_KeyDown(object sender, KeyEventArgs ex)
        {
            
            if (ex.KeyCode == Keys.Delete)
            {
                int nax = Int32.Parse(groups_grid.Rows[nn].Cells[0].Value.ToString());

                if (nax > 0)
                {
                    using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                   
                        command.CommandText = "delete from groups where id=@id";
                        command.Parameters.Add(new SqlParameter("@id", groups_grid.Rows[nn].Cells[0].Value.ToString()));
                    
                    try
                    {
                        command.ExecuteNonQuery();
                        this.groupsTableAdapter.Fill(this.baseX.groups);
                    }
                    catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                    command.Dispose();

                    connection.Close();

                    connection.Dispose();

                    }
                }
            }
        }

        private void groups_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            nn = e.RowIndex;
        }
    }
    }


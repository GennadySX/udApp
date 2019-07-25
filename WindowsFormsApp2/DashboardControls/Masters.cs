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

namespace WindowsFormsApp2.Dashboard
{
    public partial class Masters : UserControl
    {
        public Masters()
        {
            InitializeComponent();
        }

        private void Masters_Load(object sender, EventArgs e)
        {

            this.mastersTableAdapter.Fill(this.baseX.masters);
        }
        int nn;
        private void master_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            nn = e.RowIndex;
        }

        private void master_grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {  
            
            if (master_grid.Rows[e.RowIndex].Cells[1].Value.ToString() != "" && master_grid.Rows[e.RowIndex].Cells[2].Value.ToString() != "" && master_grid.Rows[e.RowIndex].Cells[3].Value.ToString() != "")
            {

                using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {

                    connection.Open();
                    int nax = Int32.Parse(master_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (nax < 0)
                    {
                        command.CommandText = "INSERT INTO masters ( name, surname, middle_name,tematic,rating,group_name,role) OUTPUT INSERTED.ID VALUES (@name,@surname,@mname,@tematic,@rating,@group_name,@role)";


                    }
                    else
                    {
                        command.CommandText = "update masters set  name=@name , surname=@sname, middle_name=@mname,tematic=@tematic, rating=@rating ,group_name=@group_name role=@role where id=@id";

                        command.Parameters.Add(new SqlParameter("@id", master_grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    }

                    //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                    command.Parameters.Add(new SqlParameter("@name", master_grid.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@sname", master_grid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@mname", master_grid.Rows[e.RowIndex].Cells[3].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@tematic", master_grid.Rows[e.RowIndex].Cells[4].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@rating", master_grid.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@group_name", master_grid.Rows[e.RowIndex].Cells[6].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@role", master_grid.Rows[e.RowIndex].Cells[7].Value.ToString()));
                    try
                    {

                        command.ExecuteNonQuery();
                        this.mastersTableAdapter.Fill(this.baseX.masters);



                    }
                    catch (SqlException es) {/* MessageBox.Show("oops " + es.ToString());*/ }
                    command.Dispose();

                    connection.Close();

                    connection.Dispose();


                }
            }
        }

        private void master_grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int nax = Int32.Parse(master_grid.Rows[nn].Cells[0].Value.ToString());

                if (nax > 0)
                {
                    using (SqlConnection connection = new SqlConnection(new Core().cdb))
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();

                        command.CommandText = "delete from masters where id=@id";
                        command.Parameters.Add(new SqlParameter("@id", master_grid.Rows[nn].Cells[0].Value.ToString()));

                        try
                        {
                            command.ExecuteNonQuery();
                            this.mastersTableAdapter.Fill(this.baseX.masters);
                        }
                        catch (SqlException es) { /* MessageBox.Show("oops " + es.ToString()); */}
                        command.Dispose();

                        connection.Close();

                        connection.Dispose();

                    }
                }
            }
        }

        private void master_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

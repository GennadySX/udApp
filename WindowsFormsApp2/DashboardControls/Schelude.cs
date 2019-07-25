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
    public partial class Schelude : UserControl
    {
        public Schelude()
        {
            InitializeComponent();
        }

        private void Schelude_Load(object sender, EventArgs e)
        {
        }


        int nn;
        private void schelude_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            nn = e.RowIndex;
        }

        private void schelude_grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (schelude_grid.Rows[e.RowIndex].Cells[1].Value.ToString() != "" && schelude_grid.Rows[e.RowIndex].Cells[2].Value.ToString() != "" && schelude_grid.Rows[e.RowIndex].Cells[3].Value.ToString() != "")
            {

                using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {

                    connection.Open();
                    int nax = Int32.Parse(schelude_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (nax < 0)
                    {
                        command.CommandText = "INSERT INTO premises ( place, contractPrice, capacity,speciality) OUTPUT INSERTED.ID VALUES (@place,@contractPrice,@capacity,@speciality)";


                    }
                    else
                    {
                        command.CommandText = "update premises set  place=@place , contractPrice=@contractPrice, capacity=@capacity,speciality=@speciality where id=@id";

                        command.Parameters.Add(new SqlParameter("@id", schelude_grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    }

                    //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                    command.Parameters.Add(new SqlParameter("@place", schelude_grid.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@contractPrice", schelude_grid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@capacity", schelude_grid.Rows[e.RowIndex].Cells[3].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@speciality", schelude_grid.Rows[e.RowIndex].Cells[4].Value.ToString()));
                   
                    try
                    {

                        command.ExecuteNonQuery();
                        this.premisesTableAdapter.Fill(this.baseX.premises);



                    }
                    catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                    command.Dispose();

                    connection.Close();

                    connection.Dispose();


                }
            }

        }

        private void schelude_grid_KeyDown(object sender, KeyEventArgs ex)
        {
            if (ex.KeyCode == Keys.Delete)
            {
                int nax = Int32.Parse(schelude_grid.Rows[nn].Cells[0].Value.ToString());

                if (nax > 0)
                {
                    using (SqlConnection connection = new SqlConnection(new Core().cdb))
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();

                        command.CommandText = "delete from premises where id=@id";
                        command.Parameters.Add(new SqlParameter("@id", schelude_grid.Rows[nn].Cells[0].Value.ToString()));

                        try
                        {
                            command.ExecuteNonQuery();
                            this.premisesTableAdapter.Fill(this.baseX.premises);
                        }
                        catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                        command.Dispose();

                        connection.Close();

                        connection.Dispose();

                    }
                }
            }
        }

        private void schelude_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class Estimate : UserControl
    {
        string user_id;
        public Estimate(string id)
        {
            InitializeComponent();
            user_id = id;
        }

        int nn;
        private void estimate_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int non = new Core().ogo(user_id);
            if (non != 0) estimate_grid.ReadOnly = true;
            nn = e.RowIndex;
        }

        private void estimate_grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (estimate_grid.Rows[e.RowIndex].Cells[1].Value.ToString() != "" && estimate_grid.Rows[e.RowIndex].Cells[2].Value.ToString() != "" && estimate_grid.Rows[e.RowIndex].Cells[3].Value.ToString() != "")
            {

                using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {

                    connection.Open();
                    int nax = Int32.Parse(estimate_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (nax < 0)
                    {
                        command.CommandText = "INSERT INTO estimate ( id_masterClass, id_students, estimate) OUTPUT INSERTED.ID VALUES (@id_masterClass,@id_students,@estimate)";


                    }
                    else
                    {
                        command.CommandText = "update estimate set  id_masterClass=@id_masterClass , id_students=@id_students, estimate=@estimate where id=@id";

                        command.Parameters.Add(new SqlParameter("@id", estimate_grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    }

                    //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                    command.Parameters.Add(new SqlParameter("@id_masterClass", estimate_grid.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@id_students", estimate_grid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@estimate", estimate_grid.Rows[e.RowIndex].Cells[3].Value.ToString()));

                    try
                    {

                        command.ExecuteNonQuery();
                        this.estimateTableAdapter.Fill(this.baseX.estimate);



                    }
                    catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                    command.Dispose();

                    connection.Close();

                    connection.Dispose();


                }
            }

        }

        private void estimate_grid_KeyDown(object sender, KeyEventArgs ex)
        {
            if (ex.KeyCode == Keys.Delete)
            {
                int nax = Int32.Parse(estimate_grid.Rows[nn].Cells[0].Value.ToString());

                if (nax > 0)
                {
                    using (SqlConnection connection = new SqlConnection(new Core().cdb))
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();

                        command.CommandText = "delete from estimate where id=@id";
                        command.Parameters.Add(new SqlParameter("@id", estimate_grid.Rows[nn].Cells[0].Value.ToString()));

                        try
                        {
                            command.ExecuteNonQuery();
                            this.estimateTableAdapter.Fill(this.baseX.estimate);
                        }
                        catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                        command.Dispose();

                        connection.Close();

                        connection.Dispose();

                    }
                }
            }
        }


    }
}

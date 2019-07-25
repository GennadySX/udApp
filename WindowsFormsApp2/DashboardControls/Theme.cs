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
    public partial class Theme : UserControl
    {
        string user_id;
        public Theme(string id)
        {
            InitializeComponent();
            user_id = id;
        }

        private void Theme_Load(object sender, EventArgs e)
        {
            int non = new Core().ogo(user_id);
            if (non != 0) thematic_grid.ReadOnly = true;
            this.tematicTableAdapter.Fill(this.baseX.tematic);
        }
        int nn;
      
        private void thematic_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            nn = e.RowIndex;
        }

        private void thematic_grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (thematic_grid.Rows[e.RowIndex].Cells[1].Value.ToString() != "" && thematic_grid.Rows[e.RowIndex].Cells[2].Value.ToString() != "" && thematic_grid.Rows[e.RowIndex].Cells[3].Value.ToString() != "")
            {

                using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {

                    connection.Open();
                    int nax = Int32.Parse(thematic_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (nax < 0)
                    {
                        command.CommandText = "INSERT INTO tematic ( qualitiesTematic, material, premises,id_master) OUTPUT INSERTED.ID VALUES (@qualitiesTematic,@material,@premises,@id_master)";


                    }
                    else
                    {
                        command.CommandText = "update tematic set  qualitiesTematic=@qualitiesTematic , material=@material, premises=@premises,id_master=@id_master  where id=@id";

                        command.Parameters.Add(new SqlParameter("@id", thematic_grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    }

                    //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                    command.Parameters.Add(new SqlParameter("@qualitiesTematic", thematic_grid.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@material", thematic_grid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@premises", thematic_grid.Rows[e.RowIndex].Cells[3].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@id_master", thematic_grid.Rows[e.RowIndex].Cells[4].Value.ToString()));
                  
                    try
                    {

                        command.ExecuteNonQuery();
                        this.tematicTableAdapter.Fill(this.baseX.tematic);



                    }
                    catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                    command.Dispose();

                    connection.Close();

                    connection.Dispose();


                }
            }

        }

        private void thematic_grid_KeyDown(object sender, KeyEventArgs ex)
        {
            if (ex.KeyCode == Keys.Delete)
            {
                int nax = Int32.Parse(thematic_grid.Rows[nn].Cells[0].Value.ToString());

                if (nax > 0)
                {
                    using (SqlConnection connection = new SqlConnection(new Core().cdb))
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();

                        command.CommandText = "delete from tematic where id=@id";
                        command.Parameters.Add(new SqlParameter("@id", thematic_grid.Rows[nn].Cells[0].Value.ToString()));

                        try
                        {
                            command.ExecuteNonQuery();
                            this.tematicTableAdapter.Fill(this.baseX.tematic);
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


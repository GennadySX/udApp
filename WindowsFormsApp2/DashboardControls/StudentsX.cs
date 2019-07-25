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
    public partial class StudentsX : UserControl
    {
        string user_id;
        public StudentsX(string id)
        {
            user_id = id;
            InitializeComponent();
        }
        int nn;
        private void studentx_grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            nn = e.RowIndex;
        }

        private void studentx_grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (studentx_grid.Rows[e.RowIndex].Cells[1].Value.ToString() != "" && studentx_grid.Rows[e.RowIndex].Cells[2].Value.ToString() != "" && studentx_grid.Rows[e.RowIndex].Cells[5].Value.ToString() != "")
            {

                using (SqlConnection connection = new SqlConnection(new Core().cdb))
                using (SqlCommand command = connection.CreateCommand())
                {

                    connection.Open();
                    int nax = Int32.Parse(studentx_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (nax < 0)
                    {
                        command.CommandText = "INSERT INTO students ( name, surname, middle_name,master,groups_id,role) OUTPUT INSERTED.ID VALUES (@name,@sname,@mname,@master,@group_id,@role)";
                        studentx_grid.Rows[e.RowIndex].Cells[6].Value = 2;

                    }
                    else
                    {
                        command.CommandText = "update students set  name=@name , surname=@sname, middle_name=@mname,master=@master, groups_id=@group_id , role=@role where id=@id";

                        command.Parameters.Add(new SqlParameter("@id", studentx_grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    }

                    //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                    command.Parameters.Add(new SqlParameter("@name", studentx_grid.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@sname", studentx_grid.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@mname", studentx_grid.Rows[e.RowIndex].Cells[3].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@master", studentx_grid.Rows[e.RowIndex].Cells[4].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@group_id", studentx_grid.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    command.Parameters.Add(new SqlParameter("@role", studentx_grid.Rows[e.RowIndex].Cells[6].Value.ToString()));
                    try
                    {

                        command.ExecuteNonQuery();
                        this.studentsTableAdapter.Fill(this.baseX.students);



                    }
                    catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                    command.Dispose();

                    connection.Close();

                    connection.Dispose();


                }
            }

        }

        private void studentx_grid_KeyDown(object sender, KeyEventArgs ex)
        {
            if (ex.KeyCode == Keys.Delete)
            {
                int nax = Int32.Parse(studentx_grid.Rows[nn].Cells[0].Value.ToString());

                if (nax > 0)
                {
                    using (SqlConnection connection = new SqlConnection(new Core().cdb))
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();

                        command.CommandText = "delete from students where id=@id";
                        command.Parameters.Add(new SqlParameter("@id", studentx_grid.Rows[nn].Cells[0].Value.ToString()));

                        try
                        {
                            command.ExecuteNonQuery();
                            this.studentsTableAdapter.Fill(this.baseX.students);
                        }
                        catch (SqlException es) { MessageBox.Show("oops " + es.ToString()); }
                        command.Dispose();

                        connection.Close();

                        connection.Dispose();

                    }
                }
            }
        }

        private void StudentsX_Load(object sender, EventArgs e)
        {
            int non = new Core().ogo(user_id);
            if (non != 0) studentx_grid.ReadOnly = true;
        }
    }
}

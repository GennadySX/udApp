using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System ;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    
    public partial class MasterClass : UserControl
    {
        public string id, id_master, id_tematic, groups, date_passage, price, id_premises,user_id;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new Core().cdb))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = "INSERT INTO groups ( [group_name], [master_id], [student_id]) output inserted.id VALUES (@group_name,@master_id,@student_id)";
                //  "Insert into users(name, surname,email,birth_date,login,password,secret_code,role,image) values ";
                command.Parameters.Add(new SqlParameter("@group_name", groups));
                command.Parameters.Add(new SqlParameter("@master_id", id_master));
                command.Parameters.Add(new SqlParameter("@student_id", user_id));
                try
                {


                    command.ExecuteNonQuery();
                    this.masterClassTableAdapter.Fill(this.udData.masterClass);
                    MessageBox.Show("Вы записались в группу!");

                }
                catch (Exception es) { MessageBox.Show("Что то не так!!!"); }
                command.Dispose();

                connection.Close();

                connection.Dispose();

            }
        
    }

        public MasterClass(string id_user)
        {
            InitializeComponent();
            user_id = id_user;

        }

        private void MasterClass_Load(object sender, EventArgs e)
        {
            int non = new Core().ogo(user_id);
            if (non != 0) masterClass_grid.ReadOnly = true;
            this.masterClassTableAdapter.Fill(this.udData.masterClass);
            
        }

        private void masterClass_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            id= masterClass_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_master= masterClass_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            id_tematic = masterClass_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            groups = masterClass_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            date_passage = masterClass_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
            price = masterClass_grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            id_premises = masterClass_grid.Rows[e.RowIndex].Cells[6].Value.ToString();
            int n = Int32.Parse(id);

            


        }


        private void postup_btn_Click(object sender, EventArgs e)
        {
        }

    }
}

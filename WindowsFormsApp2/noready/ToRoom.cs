using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ToRoom : UserControl
    {
        string user_id;
        public ToRoom(string id)
        {
            user_id = id;
            InitializeComponent();
        }

        private void ToRoom_Load(object sender, EventArgs e)
        {
            int non = new Core().ogo(user_id);
            if (non != 0) userGrid.ReadOnly = true;
            this.premisesTableAdapter.Fill(this.udData.premises);
        }
    }
}

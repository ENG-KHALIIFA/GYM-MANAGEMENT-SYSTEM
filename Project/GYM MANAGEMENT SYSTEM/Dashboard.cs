using GYM_MANAGEMENT_SYSTEM.DataConnection;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GYM_MANAGEMENT_SYSTEM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Connections cn = new Connections();
            SqlConnection conn = cn.GetSqlConnection();
            conn.Open();
            var command = new SqlCommand("select *from users", conn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                label1.Text = reader.GetString(0);
            }
            reader.Close();
            conn.Close();

        }
    }
}

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

namespace SqlConAdo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=localhost;Initial Catalog=techintalkDb;User Id=sa;Password=root;";
            string query = "select * from users";
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand comm = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show("User id is : "+ reader.GetValue(0)+" and its name is : "+ reader.GetValue(1));
            }            
        }
    }
}

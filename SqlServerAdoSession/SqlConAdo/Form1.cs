using DAL;
using System;
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
            var records = Sql.FetchRecords();
            foreach (var record in records)
            {
                MessageBox.Show(record);
            }            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickHandler(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            var clickedBtnName = Int32.Parse(clickedBtn.Text);

            Debug.WriteLine(clickedBtnName);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace childApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double marks = 0;

            if (radioButton1.Checked == true)
            {
                marks += 2;
            }
            if (radioButton6.Checked == true)
            {
                marks += 2;
            }
            if (radioButton11.Checked == true)
            {
                marks += 2;
            }

            label14.Text = marks.ToString();

            if (marks >= 4)
            {
                MessageBox.Show("Good Effort", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Try Again.....!!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}

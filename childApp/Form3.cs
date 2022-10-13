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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double marks=0;

            if(radioButton3.Checked == true)
            {
                marks += 2;
            }
            if(radioButton8.Checked == true)
            {
                marks += 2;
            }
            if(radioButton10.Checked == true)
            {
                marks += 2;
            }

            label3.Text=marks.ToString();

            if(marks >= 4)
            {
                MessageBox.Show("Good Effort","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Try Again.....!!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

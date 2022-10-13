using System;
using System.Windows.Forms;

namespace childApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 Check = new Form3();
            Check.Show();
            Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4 Check = new Form4();
            Check.Show();
            Hide();
        }

       
    }
}

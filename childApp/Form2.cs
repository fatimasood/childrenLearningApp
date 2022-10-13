using System.Windows.Forms;

namespace childApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            double marks = 0;

            if (radioButton4.Checked == true)
            {
                marks += 2;
            }
            if (radioButton6.Checked == true)
            {
                marks += 2;
            }
            if (radioButton12.Checked == true)
            {
                marks += 2;
            }

            label4.Text = marks.ToString();

            if (marks >= 4)
            {
                MessageBox.Show("Good Effort", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Try Again.....!!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}

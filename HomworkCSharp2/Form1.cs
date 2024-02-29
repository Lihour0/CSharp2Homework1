using System;
using System.Windows.Forms;

namespace HomworkCSharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = $"Name: {textBox1.Text}\nGender: {textBox2.Text}\nDate of Birth: {textBox3.Text}\nTel: {textBox4.Text}\nEmail: {textBox5.Text}";
            MessageBox.Show(message, "Information");

        }
    }
}

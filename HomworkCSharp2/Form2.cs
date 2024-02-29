using System;
using System.Windows.Forms;

namespace HomworkCSharp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += (sender, e) => Calc((x, y) => x + y);
            button2.Click += (sender, e) => Calc((x, y) => x - y);
            button3.Click += (sender, e) => Calc((x, y) => x * y);
            button4.Click += (sender, e) => Calc((x, y) => x / y);
            button5.Click += (sender, e) => Calc((x, y) => x % y);
            button6.Click += (sender, e) =>
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            };
            button7.Click += (sender, e) => Application.Exit();
        }
        public void Calc(Func<double, double, double> op)
        {
            double val1 = double.Parse(textBox1.Text);
            double val2 = double.Parse(textBox2.Text);
            double res = op(val1, val2);
            textBox3.Text = res.ToString();
        }

    }
}

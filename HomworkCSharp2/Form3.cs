using System.Windows.Forms;

namespace HomworkCSharp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button2.Click += (sender, e) => Application.Exit();
            button1.Click += (sender, e) =>
            {
                double lh = double.Parse(textBox1.Text);
                double rh = double.Parse(textBox2.Text);
                string op = radioButton1.Checked ? "+" : radioButton2.Checked ? "-" : radioButton3.Checked ? "*" : radioButton4.Checked ? "/" : radioButton5.Checked ? "%" : throw new System.Exception("Invalid Operation");
                double result = (op == "+") ? lh + rh : (op == "-") ? lh - rh : (op == "*") ? lh * rh : (op == "/") ? lh / rh : (op == "%") ? lh % rh : throw new System.Exception("Invalid Operation");
                textBox3.Text = $"{lh} {op} {rh}";
                textBox4.Text = result.ToString();
            };

        }

    }
}

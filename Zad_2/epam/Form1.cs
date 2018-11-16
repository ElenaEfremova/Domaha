using System;
using System.Windows.Forms;

namespace epam
{
    public partial class Form1 : Form
    {
        static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }

        static double SqrtN(double n, double A, double eps)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
            }

            return x1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp = SqrtN(double.Parse(textBox_degree.Text), int.Parse(textBox_var.Text), double.Parse(textBox_acc.Text));
            label_New.Text = string.Format("{0:" + "N" + Convert.ToString(textBox_acc.Text.Length - 2) + "}", temp);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            label_Pow.Text = Convert.ToString(Math.Pow(int.Parse(textBox_var.Text), 1 / double.Parse(textBox_degree.Text)));
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            label_eq.Text = (label_New.Text == "" || label_Pow.Text == "") ? "обнаружены пустые поля" :
                label_New.Text.Equals(label_Pow.Text) ? "числа равны" : "числа не равны";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
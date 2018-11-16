using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace epam_ex2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string ToBinaryUser(int value)
        {
            string binary = "";
            var stack = new Stack<int>();
            var result = new Stack<int>();
            while (value > 0)
            {
                stack.Push(value % 2);
                value /= 2;
            }
            string[] arr = stack.Select(i => i.ToString()).ToArray();
            binary = String.Join(null, arr);

            return binary;
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            textBox_bin.Text = (radioButton_lib.Checked) ? Convert.ToString(int.Parse(textBox_dec.Text), 2) + " LIB" :
                (radioButton_user.Checked) ? Convert.ToString(ToBinaryUser(int.Parse(textBox_dec.Text))) + " USER" : "";
        }

        private void radioButton_user_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6add1_epam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            textBox1.MouseWheel += new MouseEventHandler(this.textBox1_MouseWheel);

        }

        int SerialsCounter = 0;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string[] lines = Regex.Split(textBox1.Text.Trim(), "\r\n");
            SerialsCounter = lines.Length;
        }

        void textBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = SerialsCounter/3;
            if (e.Delta < 0 && progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            progressBar1.Value = 0;
            string fileName = "text.txt";
            ProgressReadStream str = new ProgressReadStream(fileName, progressBar1);

            textBox1.Text = str.ReadLines();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            string fileName = "text.txt";
            PasswordProtectedStream str = new PasswordProtectedStream(fileName, "123");

            textBox1.Text = str.ReadLines();
        }


    }
}

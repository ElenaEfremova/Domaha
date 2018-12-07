using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Laba10
{
    public partial class Form1 : Form
    {
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Старт!");
            StartRashet();
            MessageBox.Show("Отсчет завершен!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void StartRashet()
 {
     h = Convert.ToInt32(textBox1.Text);
     m = Convert.ToInt32(textBox2.Text);
     s = Convert.ToInt32(textBox3.Text);
    while (h + m + s > 0)
     {
         Rashet();
         label4.Text = Convert.ToString(h);
         label6.Text = Convert.ToString(m);
         label8.Text = Convert.ToString(s);
         Update();
         Thread.Sleep(1000);
     }
 }
   public void Rashet()  
   {
     s = s - 1;
     if (s == -1)
     {
         m = m - 1;
         s = 59;
     }

     if (m == -1)
     {
         h = h - 1;
         m = 59;
     }
        }
    }

}

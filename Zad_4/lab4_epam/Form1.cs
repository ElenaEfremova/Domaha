using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_epam
{
    public partial class Form1 : Form
    {
        private int count = 0;
        List<Triangle> list = new List<Triangle>();

        public Form1()
        {
            InitializeComponent();
            listBox1.MultiColumn = false;
            listBox1.SelectionMode = SelectionMode.One;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle obj = new Triangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                list.Add(obj);
                listBox1.BeginUpdate();
                listBox1.Items.Add("Item " + count + " " + list[count++].getStringABC());
                listBox1.EndUpdate();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            int index = listBox1.FindString(curItem);
            label1.Text = "Периметр: " + list[index].perimeter().ToString();
            label2.Text = "Площадь: " + list[index].value().ToString();
        }
    }
}

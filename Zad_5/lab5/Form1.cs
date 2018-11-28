using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private int count = 0;
        List<Vector> list = new List<Vector>();
        Vector vector = new Vector(0, 0, 0);
        private double scalar;
        private int indexOne = -1;
        private int indexTwo = -1;

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
                Vector obj = new Vector(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                list.Add(obj);
                listBox1.BeginUpdate();
                listBox2.BeginUpdate();
                listBox1.Items.Add("Item " + count + " " + list[count].ToString());
                listBox2.Items.Add("Item " + count + " " + list[count++].ToString());
                listBox1.EndUpdate();
                listBox2.EndUpdate();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            int index = listBox1.FindString(curItem);
            indexOne = index;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox2.SelectedItem.ToString();
            int index = listBox2.FindString(curItem);
            indexTwo = index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indexOne == indexTwo)
            {
                MessageBox.Show("Выбран один и тот же вектор");
            }
            else if (indexOne != -1 && indexTwo != -1)
            {
                vector = list[indexOne] * list[indexTwo];
                scalar = list[indexOne] ^ list[indexTwo];
                label1.Text = "Векторное произведение: " + vector.ToString();
                label2.Text = "Скалярное произведение: " + scalar;
                vector = list[indexOne] + list[indexTwo];
                label3.Text = "Сумма векторов: " + vector.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Polynomial obj = new Polynomial(textBox4.Text);
            Polynomial obj2 = new Polynomial(textBox5.Text);
            
            if (radioButton1.Checked)
            {
                label4.Text = obj.diff(obj2);
            }
            else if (radioButton2.Checked)
            {
                label4.Text = obj.sum(obj2);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab3_EPAM
{
    public partial class Form1 : Form
    {
        static string selectedState = ""; //цвет графика

        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = comboBox1.SelectedItem.ToString();
        }


        private void Solve1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (TextBox tx in Controls.OfType<TextBox>())
            {
                if (tx.Text != "") { count++; }
            }
            label4.Text = Convert.ToString(count);
            switch (count)
            {
                case 1:
                    label4.Text = textBox1.Text;
                    break;
                case 2:
                    label4.Text = Convert.ToString(Nod.nodBigInput(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
                    break;
                case 3:
                    label4.Text = Convert.ToString(Nod.nodBigInput(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
                    break;
                case 4:
                    label4.Text = Convert.ToString(Nod.nodBigInput(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)));
                    break;
                case 5:
                    label4.Text = Convert.ToString(Nod.nodBigInput(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text)));
                    break;
            }
        }

        private void Solve2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Nod.binaryGCD(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
        }

        private void buildChart_Click(object sender, EventArgs e)
        {
            long elapsedMilliseconds_GCD, elapsedMilliseconds_binaryGCD;
            int a = 116150;
            int b = 232704;
            Nod.GCD(a, b, out elapsedMilliseconds_GCD);
            Nod.binaryGCD(a, b, out elapsedMilliseconds_binaryGCD);
            goBuildChart(elapsedMilliseconds_GCD, elapsedMilliseconds_binaryGCD);
            label2.Text = "Время евклид: " + Convert.ToString(elapsedMilliseconds_GCD);
            label3.Text = "Время бинарный: " + Convert.ToString(elapsedMilliseconds_binaryGCD);
        }

        public void goBuildChart(long elapsedMilliseconds_GCD, long elapsedMilliseconds_binaryGCD)
        {
            chart1.Series["time"].Points.Clear();
            
            if (radioButton1.Checked) {
                chart1.Series["time"].ChartType = SeriesChartType.Column;
            } else if (radioButton2.Checked) {
                chart1.Series["time"].ChartType = SeriesChartType.Bar;
            }

            if (selectedState.Equals("Фиолетовый")) {
                chart1.Palette = ChartColorPalette.Berry;
            } else if (selectedState.Equals("Желтый")) {
                chart1.Palette = ChartColorPalette.Fire;
            }

            chart1.Series["time"].Points.AddXY("GCD", elapsedMilliseconds_GCD);
            chart1.Series["time"].Points.AddXY("binaryGCD", elapsedMilliseconds_binaryGCD);
        }
    }

    public static class Nod
    {
        public static int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        public static int nodBigInput(params int[] values)
        {
            int result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                result = GCD(result, values[i]);
            }
            return result;
        }

        public static int binaryGCD(int value1, int value2)
        {
            if (value1 == 0) return value2;
            if (value2 == 0) return value1;
            if (value1 == value2) return value1;

            bool value1IsEven = (value1 & 1u) == 0;
            bool value2IsEven = (value2 & 1u) == 0;

            if (value1IsEven && value2IsEven)
                return binaryGCD(value1 >> 1, value2 >> 1) << 1;
            else if (value1IsEven && !value2IsEven)
                return binaryGCD(value1 >> 1, value2);
            else if (value2IsEven)
                return binaryGCD(value1, value2 >> 1);
            else if (value1 > value2)
                return binaryGCD((value1 - value2) >> 1, value2);
            else
                return binaryGCD(value1, (value2 - value1) >> 1);
        }

        public static int binaryGCD(int a, int b, out long elapsedMilliseconds_binaryGCD)
        {
            int result = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 1; i < 2000000; i++) {
                binaryGCD(a, b);
            }
            stopWatch.Stop();
            elapsedMilliseconds_binaryGCD = stopWatch.ElapsedMilliseconds;
            result = binaryGCD(a, b);
            return result;
        }

        public static int GCD(int a, int b, out long elapsedMilliseconds_GCD)
        {
            int result = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 1; i < 2000000; i++)
            {
                GCD(a, b);
            }            
            stopWatch.Stop();
            elapsedMilliseconds_GCD = stopWatch.ElapsedMilliseconds;
            result = GCD(a, b);
            return result;
        }
    }
}
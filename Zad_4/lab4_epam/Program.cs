using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_epam
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c) {
            if (a + b > c && a + c > b && b + c > a) {
                this.a = a;
                this.b = b;
                this.c = c;
            } else {
                throw new Exception("Введены недопустимые значения");
            }
        }

        public string getStringABC() {
            return "(" + a + " " + b + " " + c + ")";
        }


        public double perimeter() {
            return a+b+c;
        }

        public double value() {
            double halfPer = perimeter() / 2;
            return Math.Sqrt( halfPer * (halfPer-a) * (halfPer-b) * (halfPer-c) );
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

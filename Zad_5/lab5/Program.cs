using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace lab5
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return "(" + x + " " + y + " " + z + ")";
        }

        //векторное
        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }
        //скалярное
        public static double operator ^(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }
        //сложение
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }
    }

    public class Polynomial
    {
        private Dictionary<string, double> dist = new Dictionary<string, double>();
        
        public Polynomial (string str)
        {
            string[] words = Regex.Split(str, "([a-z])");

            if (words[words.Length - 1] == "")
            {
                for (int i = 0; i < words.Length - 2; i += 2)
                {
                    dist.Add(words[i + 1], double.Parse(words[i]));
                }
            }
            else
            {
                str += "empty";
                words = Regex.Split(str, "([a-z]+)");

                for (int i = 0; i < words.Length - 1; i += 2)
                {
                    dist.Add(words[i + 1], double.Parse(words[i]));
                }

                dist.Add("", dist["empty"]);
                dist.Remove("empty");
            }
        }

        public string printPolynomial()
        {
            StringBuilder str = new StringBuilder();

            foreach (var element in dist)
            {
                if (element.Value < 0 || element.Key == dist.First().Key)
                {
                    str.Append(element.Value + "" + element.Key);
                }
                else if (element.Value > 0)
                {
                    str.Append("+" + element.Value + "" + element.Key);
                }
            }
            return str.ToString();
        }

        public Dictionary<string, double> getPolynomial()
        {
            return dist;
        }

        public string sum(Polynomial o)
        {
            foreach (var element in o.getPolynomial())
            {
                if (dist.ContainsKey(element.Key))
                {
                    if ((dist[element.Key] += element.Value) == 0) 
                    {
                        dist.Remove(element.Key);
                    }
                }
                else
                {
                    dist.Add(element.Key, element.Value);
                }
            }

            return this.printPolynomial();
        }

        public string diff(Polynomial o)
        {
            foreach (var element in o.getPolynomial())
            {
                if (dist.ContainsKey(element.Key))
                {
                    if ((dist[element.Key] -= element.Value) == 0)
                    {
                        dist.Remove(element.Key);
                    }
                }
                else
                {
                    dist.Add(element.Key, element.Value);
                }
            }

            return this.printPolynomial();
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

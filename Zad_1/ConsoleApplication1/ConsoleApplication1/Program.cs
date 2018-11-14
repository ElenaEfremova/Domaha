using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        //разбивает строки на подстроки и парсит в decimal
        static List<decimal> add(ref List<string> lines)
        {
            List<decimal> coord = new List<decimal>();

            foreach (string line in lines) {
                String[] substrings = line.Split(',');

                foreach (var substring in substrings) {
                    coord.Add(decimal.Parse(substring, CultureInfo.InvariantCulture));
                }
            }
            lines.Clear();

            return coord;
        }

        //записывает в файл
        static void addFile(List<decimal> coord)
        {
            if (File.Exists("newFile.txt") != true) {
                using (StreamWriter sw = new StreamWriter(new FileStream("newFile.txt", FileMode.Create, FileAccess.Write))) {
                    for (int i = 0; i < coord.Count;) {
                        sw.WriteLine("X: " + coord[i++] + " Y: " + coord[i++]);
                    }
                }
            } else {
                using (StreamWriter sw = new StreamWriter(new FileStream("newFile.txt", FileMode.Open, FileAccess.Write))) {
                    (sw.BaseStream).Seek(0, SeekOrigin.End);
                    for (int i = 0; i < coord.Count;) {
                        sw.WriteLine("X: " + coord[i++] + " Y: " + coord[i++]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 - введите координаты");
            Console.WriteLine("2 - сортирует значения в файле");
            Console.WriteLine("0 - сортировка");
            List<string> lines = new List<string>();
            List<decimal> coord = new List<decimal>();

            label:
            int caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    string str = "";
                    while (str != "0") {
                        lines.Add(str = Console.ReadLine());
                    }
                    lines.Remove("0");

                    coord = add(ref lines);
                    for (int i = 0; i < coord.Count;) {
                        Console.WriteLine("X: " + coord[i++] + " Y: " + coord[i++]);
                    }
                    coord.Clear();
                    goto label;
                case 2:
                    string[] allText = File.ReadAllLines("file.txt");
                    foreach (string line in allText) {
                        lines.Add(line);
                    }

                    coord = add(ref lines);
                    addFile(coord);
                    coord.Clear();
                    goto label;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            
        }
    }
}

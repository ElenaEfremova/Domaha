using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
   public class Matrix
    {
        int n;
        double[,] data;


        public Matrix(int n)
        {
            this.n = n;
            data = new double[n, n];

        }
        public Matrix(int n, double x1, double x2, double x3, double y1, double y2, double y3, double z1, double z2, double z3)
        {
            data = new double[3, 3];
            this.n = n;
            data[0, 0] = x1;
            data[0, 1] = x2;
            data[0, 2] = x3;
            data[1, 0] = y1;
            data[1, 1] = y2;
            data[1, 2] = y3;
            data[2, 0] = z1;
            data[2, 1] = z2;
            data[2, 2] = z3;



        }

        public void Create()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    data[i, j] = rnd.Next(1, 10) + Math.Round(rnd.NextDouble(), 2);
                }
            }
        }
        public void GetEmpty()
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    data[i, j] = 0;
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double sss = Math.Round(data[i, j], 4);
                    Console.Write("{0,10}", sss + "    ");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.n);
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.n; j++)
                {
                    C.data[i, j] = A.data[i, j] + B.data[i, j];
                }
            }
            return C;
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            Matrix D = new Matrix(A.n);
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.n; j++)
                {
                    D.data[i, j] = A.data[i, j] - B.data[i, j];
                }
            }
            return D;
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix E = new Matrix(A.n);
            E.GetEmpty();
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.n; j++)
                {

                    for (int k = 0; k < A.n; k++)
                    {
                        E.data[i, j] = E.data[i, j] + A.data[k, j] * B.data[i, k];
                    }
                }
            }
            return E;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размерность матрицы N");
            try
            {

                int n = int.Parse(Console.ReadLine());
                string result = "Вы ввели число " + n;

                Console.WriteLine("Матрица А:");
                Matrix A = new Matrix(n);
                A.Create();
                A.Print();
                Console.WriteLine();
                Console.WriteLine("Матрица B:");
                Matrix B = new Matrix(n);
                B.Create();
                B.Print();
                Console.WriteLine("Сложение матриц:");
                Console.WriteLine();
                Matrix C = A + B;
                C.Print();
                Console.WriteLine("Умножение матриц:");
                Console.WriteLine();
                C = A * B;
                C.Print();
                Console.WriteLine("Разность матриц:");
                Console.WriteLine();
                C = A - B;
                C.Print();
            }
            catch (FormatException)
            {
                string result = "Ошибка. Вы ввели не число";
                Console.WriteLine(result);
            }
            catch (OverflowException)
            {
                string result = "Ошибка. Вы ввели отрицательное число!";
                Console.WriteLine(result);
            }
            Console.ReadLine();

        }
    }
}

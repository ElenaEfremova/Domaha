using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public class File_my : IDisposable  //интерфейс по освобождению ресурсов
    {
        bool disposed = false;
        string pass;
        int n;
        public void Dispose()
        {
            Console.WriteLine("Высвобождение объекта!");
        }
  //      public File_my(string pass, int n) 
        private File_my(string pass, int n)
        {
            FileStream file = new FileStream(pass, FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file); //создаем «потоковый писатель» и связываем его с файловым потоком
            writer.Write("[01] Привет мир!", System.Text.Encoding.Default); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
            Console.WriteLine("Текст записан в файл");
        }
           
            public static File_my Create(string pass, int n)
            {
                File_my Inst = new File_my(pass,n);
                return Inst;
            }
            private  File_my(string pass)
            {
                FileStream file = new FileStream(pass, FileMode.Create); //создаем файловый поток

            }

            public static File_my Read(string pass)
            {
                 File_my Inst = new File_my(pass);
                 return Inst;
            }

        public int Length(string pass)
        {   string text;
        using (StreamReader sr = new StreamReader(pass, System.Text.Encoding.GetEncoding("windows-1251")))
                {
                    text = sr.ReadToEnd();
                   
                }
            return text.Length;
        }
        public string this[string pass, int anIndex] // индексатор
        {
            //Метод доступа get
            get {
                string text = "";
                using (StreamReader sr = new StreamReader(pass, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
 //                   text = "[01] Привет мир!";
               
                }
                //            string text_ = Encoding.Convert(text, 1251, 866);
               
                return text.Substring(anIndex, 1); 
            }
            //Метод доступа set
               
                 set {
                     string text;

                     using (StreamReader sr = new StreamReader(pass, System.Text.Encoding.GetEncoding("windows-1251")))
                     {
                         text = sr.ReadToEnd();
                         text = text.Substring(0, anIndex) + value + text.Substring(anIndex+1);
                         sr.Dispose();
   //                      sr.Close();
                         using (StreamWriter sw = new StreamWriter(pass, false, System.Text.Encoding.GetEncoding("windows-1251")))
                         {
                             sw.WriteLine(text);
                            
                         }
                       
                     } 
                   
                 }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {    int n=100;
        
            string fileName = "C:/laba8.txt";
       
      //            File_my A = new File_my(fileName,n); // при открытом конструкторе
          
            File_my A = File_my.Create(fileName, n); // при закрытом конструкторе
                       A[fileName, 2] = "2";




           Console.WriteLine("Длина массива = "+(A.Length(fileName)-11));
           A.Dispose();
   //          File_my B= File_my.Read(fileName); // при закрытом конструкторе     

             Console.ReadLine();
        }
    }
}

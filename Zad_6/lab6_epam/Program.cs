using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_epam
{
    class Program
    {
        static void Main(string[] args)
        {
            var interfaceType = typeof(ICodeChecker);
            List<ProgramConverter> list = new List<ProgramConverter>();

            list.Add(new ProgramConverter());
            list.Add(new ProgramConverter());
            list.Add(new ProgramHelper());
            list.Add(new ProgramConverter());
            list.Add(new ProgramHelper());

            foreach (var element in list)
            {
                if (interfaceType.IsInstanceOfType(element))
                {
                    Console.WriteLine(element.ConvertToCSharp("true ConvertToCSharp"));
                }
                else
                {
                    Console.WriteLine(element.ConvertToCSharp("false ConvertToCSharp"));
                    Console.WriteLine(element.ConvertToVB("false ConvertToVB"));
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_epam
{
    class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string s1, string s2)
        {
            return (s1.Equals(s2)) ? true : false;
        }
    }
}

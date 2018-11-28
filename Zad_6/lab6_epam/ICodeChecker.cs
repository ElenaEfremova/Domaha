using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_epam
{
    public interface ICodeChecker
    {
        bool CheckCodeSyntax(string s1, string s2);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_epam
{
    public interface IConvertible
    {
        string ConvertToCSharp(string s);
        string ConvertToVB(string s);
    }
}

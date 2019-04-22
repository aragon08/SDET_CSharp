using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET_CSharpE3
{
    class ClassA
    {
        public void TwoStrings(string a, string b)
        {
            if (a.Length==b.Length) Console.WriteLine("The length of {0} and {1} is the same",a,b);
            else Console.WriteLine("The length of {0} and {1} is not the same", a, b);
        }

        public void TwoLists(List<string> x, List<string> y)
        {
            if (x.Count == y.Count ) Console.WriteLine("The length of {0} and {1} is the same", x, y);
            else Console.WriteLine("The length of {0} and {1} is not the same", x, y);
        }

    }
}

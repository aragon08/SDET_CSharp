using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET_CSharpE3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB obj1 = new ClassB();
            obj1.TwoStrings("Hello","Worlds");
            obj1.TwoStrings("uno", "dos");
            //obj1.TwoLists("uno","dos");
        }
    }
}

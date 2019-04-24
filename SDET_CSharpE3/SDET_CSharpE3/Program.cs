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
            
            List<int> l1 = new List<int>() {1,2,3,4,5,6,7,8,9 };
            List<int> l2 = new List<int>() {1,2,3,4,5,6,7,8,9 };
            List<int> l3 = new List<int>() {1,2,3,4,5,6 };
            obj1.TwoLists(l1,l2);
            obj1.TwoLists(l1,l3);

            //Interface
            //obj1.SayHello();
            ISDET3 hi = new ClassB();
            hi.SayHello();

            //List of strings
            List<String> words = new List<string>() { "Text","Computer","Automation","Visual Studio","Auto Parts"," " };
            obj1.wds(words);

            //List of integers duplicated
            List<int> numD = new List<int>() {1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
            obj1.duplicates(numD);
        }
    }
}

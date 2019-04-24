using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET_CSharpE3
{
    class ClassB : ClassA, ISDET3
    {
        public void SayHello()
        {
            Console.WriteLine("Hello Interface");
        }

        public void wds(List<string> words)
        {
            Console.WriteLine("------------------------------");
            words.Sort();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            words.Reverse();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
        }

        public void spaces(List<string> words)
        {

        }

        public void duplicates(List<int> duplicated)
        {

        }

    }
}

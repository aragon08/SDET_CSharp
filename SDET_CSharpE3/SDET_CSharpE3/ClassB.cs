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
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Hello Interface");
        }

        public void wds(List<string> words)
        {
            Console.WriteLine("--------------------------------------------------------------------");
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
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public void spaces(List<string> words)
        {
            IEnumerable<string> filter = from w in words
                                         where !w.Contains(" ")
                                         select w;
            foreach (var i in filter)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public void duplicates(List<int> duplicated)
        {
            List<int> list2 = new List<int>();

            foreach (var item in duplicated.Distinct())
            {
                list2.Add(item);                
            }
                        
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }

    }
}

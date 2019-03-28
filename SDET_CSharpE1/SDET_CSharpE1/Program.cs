using System;
using System.Collections.Generic;

namespace SDET_CSharpE1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method 1 from FirstOne.class
            FirstOne comp = new FirstOne();

            try
            {
                string compW = comp.compaWs("a", "b");
                bool value = Convert.ToBoolean(compW);
                if (value == true)
                {
                    Console.WriteLine("The two words are the same.");
                }
                else
                {
                    Console.WriteLine("The two words are different.");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Method 2 from FirstOne.class
            List<int> num2 = new List<int>() { 1, 5, 3, 6, 8, 9, 10, 13, 80 };
            FirstOne bigNum = new FirstOne();
            bigNum.bigN(num2);
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Method 3 from FirstOne.class
            string[] num3 = { "11", "2", "1", "62", "18", "9", "10", "13" };
            string[] num4 = { "2", "4", "7", "3", "8", "5", "13", "54" };
            bigNum.sort(num3, num4);
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Method 4 from FirstOne.class
            FirstOne lth = new FirstOne();
            int str = lth.countLength("Black Wolf");
            Console.WriteLine("The lenght is {0}", str);
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Method 1 from SecondOne.class
            List<int> lst = new List<int> { 14, 5, 9, 45, 9, 44, 89, 8 };
            SecondOne fastFive = new SecondOne();
            fastFive.firstFive(lst);
            Console.WriteLine("\n--------------------------------------------------------------------------------");

            //Method 2 from SecondOne.class
            int[] smallNum = { 12, 4, 76, 3, 97, 3, 65, 2 };

            fastFive.smallestN(smallNum);
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Method 3 from SecondOne.class
            fastFive.basedKey();
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_CSharpE1
{
    class SecondOne
    {
        public void firstFive(List<int> ff)
        {
            List<int> five = ff;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(five[i] + " ");
            }

        }

        public void smallestN(int[] sn)
        {
            int k = sn.Length;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k - 1; j++)
                {
                    if (sn[j] > sn[j + 1])
                    {
                        int aux = sn[j + 1];
                        sn[j + 1] = sn[j];
                        sn[j] = aux;
                    }
                }
            }
            Console.WriteLine("The smallest number is:{0}", sn[0]);
        }

        public void basedKey()
        {
            Dictionary<int, string> persona = new Dictionary<int, string>();

            persona.Add(1, "Andrea");
            persona.Add(2, "Carlos");
            persona.Add(3, "Jose");
            persona.Add(4, "Marisol");
            persona.Add(5, "Miguel");
            persona.Add(6, "Valeria");
            persona.Add(7, "Roman");
            persona.Add(8, "Romina");

            foreach (var key in persona)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_CSharpE1
{
    class FirstOne
    {
        // 1 Metodo comparar 2 words
        public string compaWs(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                throw new Exception("Null or empty value is not allowed");
            }
            return Convert.ToString(a == b);

        }

        //// 2 Metodo numero grande de lista
        public bool bigN(List<int> lista)
        {
            try
            {
                int? nM = null;
                foreach (var nTmp in lista)
                {
                    if (nM == null)
                    {
                        nM = nTmp;
                    }
                    else
                    {
                        if (nTmp > nM)
                            nM = nTmp;
                    }
                }
                Console.WriteLine("The biggest number is:{0}", nM);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //// 3 metodo ordenar lista asc y desc
        public void sort(string[] r, string[] s)
        {
            int p = r.Length;
            int q = s.Length;

            int aux = 0;
            int auxD = 0;

            int[] pInt = new int[p];
            int[] qInt = new int[q];
            var index = 0;
            var index2 = 0;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Disordered ASC");
            foreach (var aux1 in r)
            {
                int value1Int = Convert.ToInt32(aux1);
                pInt[index] = value1Int;
                Console.Write(value1Int + " ");
                index++;
            }

            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < p - 1; j++)
                {
                    if (pInt[j] > pInt[j + 1])
                    {
                        aux = pInt[j + 1];
                        pInt[j + 1] = pInt[j];
                        pInt[j] = aux;
                    }
                }
            }

            Console.WriteLine("\nASC");

            foreach (var x in pInt)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Disordered Desc");
            //for (int i = 0; i < s.Length; i++)
            //{
            //    qInt[i] = Convert.ToInt32(s[i]);
            //}
            foreach (var aux2 in s)
            {
                int value2Int = Convert.ToInt32(aux2);
                qInt[index2] = value2Int;
                Console.Write(+value2Int + " ");

                index2++;
            }

            for (int i = 0; i < q; i++)
            {
                for (int j = 0; j < q - 1; j++)
                {
                    if (qInt[j] < qInt[j + 1])
                    {
                        auxD = qInt[j + 1];
                        qInt[j + 1] = qInt[j];
                        qInt[j] = auxD;
                    }
                }
            }
            Console.WriteLine("\nDESC");

            foreach (var y in qInt)
            {
                Console.Write(y + " ");
            }

            Console.WriteLine("\n------------------------------------");


        }

        // 4 Metodo contar longitud de string
        public int countLength(string d)
        {
            char[] array = d.ToCharArray();
            int msg = 0;//= array.Length;
            foreach (var value in array)
            {
                msg = msg + 1;
            }

            return msg;
        }
    }
}

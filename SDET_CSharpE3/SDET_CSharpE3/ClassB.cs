using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

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

        //3-1 XML TextReader

        public void readXML()
        {
            XmlTextReader reader = new XmlTextReader("breakfast_menu.xml");
            //XmlTextReader reader = new XmlTextReader("C:\\Users\\Orion\\Source\\Repos\\SDET_CSharp\\SDET_CSharpE3\\SDET_CSharpE3\bin\\Debug\\breakfast_menu.xml");


            while (reader.Read())
            {
                string tmpName = "";
                if (reader.NodeType == XmlNodeType.Element && reader.Name.ToString() == "name")
                {
                    reader.Read();

                    //var el = reader.ReadElementContentAsObject();
                    //reader.GetAttribute()
                    //Console.Write(el.ToString());
                    //Console.Write(reader.Name == "price" ? reader.Value : "te la pelas");
                    //Console.WriteLine("-----------------------------------------------------------");
                    //Console.WriteLine(reader.Name.ToString());

                    //Console.Write(reader.Value); //nombre
                    tmpName = reader.Value;

                    //while (reader.Read())
                    //{
                    //    if(reader.Name.ToString() == "price")
                    //    {
                    //        reader.Read();
                    //        tmpName += reader.Value;
                    //        Console.WriteLine(tmpName);
                    //    }
                    //    break;
                    //}
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    tmpName += " Price: " + reader.Value.ToString();
                    Console.WriteLine(tmpName.ToString().ToString());
                }

            }
        }
    }
}

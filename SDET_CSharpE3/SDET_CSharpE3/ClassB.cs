﻿using System;
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
    }
}

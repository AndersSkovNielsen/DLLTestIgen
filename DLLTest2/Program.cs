﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myMathDLL;

namespace DLLTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Add(2,4));
            Console.WriteLine(MyMath.Subtract(5,3));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnVjezbaVarijableIspisPodataka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 3, x, y;
            x = a / b;
            y = a % b;

            Console.WriteLine(a + " dijeljeno s " + b + " je " + x + " s ostatkom " + y);
            Console.ReadKey();
        }
    }
}

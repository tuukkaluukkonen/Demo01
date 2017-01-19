﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask a number
            int number;
            Console.Write("Give a number >");
            string line = Console.ReadLine();   // "1"
            number = int.Parse(line); // "1" -> 1
            // switch number..
            switch (number)
            {
                case 1: Console.Write("yksi"); break;
                case 2: Console.Write("kaksi"); break;
                case 3: Console.Write("kolme"); break;
                default: Console.Write("joku muu luku"); break;
            }
            // wait enter...
            Console.ReadLine();
        }
    }
}

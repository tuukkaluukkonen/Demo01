using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01b
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask a number
            int number;
            Console.Write("Give a number >");
            string line = Console.ReadLine();   // "1"
            bool result = int.TryParse(line, out number);
            if (result == true)
                {
                // switch number..
                switch (number)
                {
                    case 1: Console.Write("yksi"); break;
                    case 2: Console.Write("kaksi"); break;
                    case 3: Console.Write("kolme"); break;
                    default: Console.Write("joku muu luku"); break;
                }
            } else
            {
                Console.WriteLine("Not a integer value!");
            }
            // wait enter...
            Console.ReadLine();
        }
    }
}

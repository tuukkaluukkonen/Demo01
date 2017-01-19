using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuosiluku > ");
            int vuosiluku = int.Parse(Console.ReadLine());

            if (vuosiluku % 4 == 0 && vuosiluku % 100 != 0 || vuosiluku % 400 == 0)
            Console.WriteLine("Vuosi on karkausvuosi");
        
      
            else
            Console.WriteLine("Vuosi ei ole karkausvuosi ");

        }
    }
}

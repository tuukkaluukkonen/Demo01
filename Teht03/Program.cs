using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask a number
            
            Console.Write("Anna ensimmäinen luku >");
            int luku = int.Parse(Console.ReadLine());

            Console.Write("Anna toinenn luku >");
            int luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku >");
            int luku3 = int.Parse(Console.ReadLine());

            int Summa = (luku + luku2 + luku3);
            int Keskiarvo = ((luku + luku2 + luku3) / 3);

            Console.Write("Summa = " + Summa );
            Console.Write("\n");
            Console.Write("Keskiarvo = " + Keskiarvo);
            Console.Write("\n");

        }
    }
}

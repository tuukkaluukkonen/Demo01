using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku > ");
            int luku1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Anna luku > ");
            int luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku > ");
            int luku3 = int.Parse(Console.ReadLine());

            {

                if (luku1 > luku2 && luku1 > luku3)
                    Console.WriteLine("Suurin luku on " + luku1);

                else if (luku2 > luku1 && luku2 > luku3)
                    Console.WriteLine("Suurin luku on " + luku2);

                else if (luku3 > luku2 && luku3 > luku1)
                    Console.WriteLine("Suurin luku on " + luku3);
            }
        }
    }
}

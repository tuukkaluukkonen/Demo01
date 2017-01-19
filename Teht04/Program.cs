using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            // kysytään ikä
            Console.Write("Anna ikäsi: ");
            int ika = int.Parse(Console.ReadLine());

            if (ika < 18) Console.Write("alaikäinen");
            else if (ika >= 18 && ika <= 65) Console.Write("aikuinen");
            else Console.Write("seniori");

            Console.ReadLine();

        }
    }
}

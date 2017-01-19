using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ajettu matka > ");
            double matka = double.Parse(Console.ReadLine());

            double litrat = (matka / 100 * 7.02);
            double kustannus = (litrat * 1.595);

            Console.WriteLine("Bensaa kuluu > " + litrat + " litraa, " + "kustannus " + kustannus + " euroa" );
        }
    }
}

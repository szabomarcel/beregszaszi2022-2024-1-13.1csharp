using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percek_es_orak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Add meg a másodpercet:");
            string mp = Console.ReadLine();
            int masodperc, perc, ora, nap;
            masodperc = int.Parse(mp);
            Console.WriteLine("Ennyi másodperc: {0}", masodperc);
            perc = masodperc / 60;
            Console.WriteLine("Ennyi perc: {0}", perc);
            ora = masodperc / 3600;
            Console.WriteLine("Ennyi óra: {0}", ora);
            nap = masodperc / 86400;
            Console.WriteLine("Ennyi nap: {0}", nap);
            Console.ReadKey();
        }
    }
}

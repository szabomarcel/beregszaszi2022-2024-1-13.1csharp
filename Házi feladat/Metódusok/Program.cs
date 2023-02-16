using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metódusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "egyik";
            string b = "másik";
            int x = String.Compare(a, b);
            if (x == 0) // eldöntendő: ha x == a 0-val
            {
                Console.WriteLine("A két string egyenlő");
            }
            else if (x < 0) // eldöntendő: ha x < mint a 0
            {
                Console.WriteLine("A 'a' a kisebb");
            }
            else // eldöntendő: ha eltér
            {
                Console.WriteLine("A 'b' a kisebb");
            }
            Console.ReadKey();  
        }
    }
}
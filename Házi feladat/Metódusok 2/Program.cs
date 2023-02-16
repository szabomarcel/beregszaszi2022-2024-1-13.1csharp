using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metódusok_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // alap
            string s = "nagy hosszú hosszú szöveg"; // szöveg kiíratás
            char[] chr = new char[] {'y', 'z', 'o', 's', 'g'};
            Console.WriteLine(s.IndexOf('r')); // 2
            Console.WriteLine(s.IndexOfAny(chs)); // 3
            Console.WriteLine(s.LastIndexOf('n')); // 16
            Console.WriteLine(s.LastIndexOfAny(chs)); // 9
            Console.WriteLine(s.Contains("long"));

            // Módositás
            Console.WriteLine(s.Replace('s', 'l')); // Cserélt szöveg
            Console.WriteLine(s.Trim(chs)); // Vágásos szöveg
            Console.WriteLine(s.Insert(0, "one")); // Beszúrás szöveg
            Console.WriteLine(s.Remove(0, 2)); // Eltávolitott szöveg
            Console.WriteLine(s.Substring(0, 3)); // Alkarakterlánc szöveg
            Console.WriteLine(s.ToUpper()); // Felemelő
            Console.WriteLine(s.ToLower()); // Leemelő


            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ez egy string";
            Console.WriteLine(s[0]); // e 
            foreach(char ch in s) 
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("ez egy string"[4]); // y 
            Console.ReadKey();
        }
    }
}

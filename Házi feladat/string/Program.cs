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
            StringBuilder sb = new StringBuilder(50);
            for (char ch = 'a'; ch <= 'z'; ++ch)
            {
                sb.Append(ch);
            }
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
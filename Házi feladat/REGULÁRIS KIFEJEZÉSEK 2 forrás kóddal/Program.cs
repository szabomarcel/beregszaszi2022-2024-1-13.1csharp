using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGULÁRIS_KIFEJEZÉSEK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = @"^(\+)[1-9][0-9]{1,2}\s[1-9][0-9]{1,2}\s(\d{3}(-)){2}\d{3}$"; // szöveg kiíratás
            Regex pattern = new Regex(s);
            string s1 = "+36 30 661-345-612"; // 1.szöveg kiíratás
            string s2 = "+3630 661-567-233"; // 2.szöveg kiíratás
            string s3 = "+56 30 667-876-987-456"; // 3.szöveg kiíratás
            Console.WriteLine(pattern.IsMatch(s1)); // true
            Console.WriteLine(pattern.IsMatch(s2)); // false
            Console.WriteLine(pattern.IsMatch(s3)); // false
        }
    }
}
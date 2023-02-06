using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamok_bekeres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írjon be egy számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy osztot!");
            int oszto = Convert.ToInt32(Console.ReadLine());


            int egeszresz = szam / oszto;
            int maradek = szam % oszto;
            Console.WriteLine("Az osztás eredménye:" + egeszresz);
            if(szam == 0)
            {
                Console.WriteLine("Az osztásnak nincs maradéka!");
            }
            else
            {
                Console.WriteLine("Az osztás maradéka:"+maradek);
            }
            Console.ReadKey();
        }
    }
}

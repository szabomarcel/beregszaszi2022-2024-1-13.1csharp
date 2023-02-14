using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUBORÉKRENDEZÉS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // első változatt
            for (int i = 0, i < sor.Length - 1; ++i)
            {
                for(int j = sor.Length - 1; > i; --j)
                {
                    int tmp = sor[j];
                    sor[j] = sor[j - 1];
                    sor[j - 1] = tmp;
                }
            }

            // második változatt
            for (int i = 1; i < sor.Length; ++i)
            {
                int y = sor[i];
                int j = i - 1;
                while(j>-1 && y < sor[j])
                {
                    sor[j + 1] = sor[j];
                    --j;
                }
                sor[j + 1] = y
            }
        }
    }
}

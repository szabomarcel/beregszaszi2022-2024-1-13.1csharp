using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_es_maximum_kereses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1000;
            int max = -1;
            int minIdx = 0;
            int maxIdx = 0;
            for (int i = 0; i < 30; ++i)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIdx = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxIdx = i;
                }
            }
        }
    }
}

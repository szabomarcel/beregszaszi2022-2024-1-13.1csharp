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
            int min = 1000; //minimum érték
            int max = -1; //maximum érték
            int minIdx = 0; //minimum Index érték
            int maxIdx = 0; //maximum Index érték
            
            // eldöndendő
            for (int i = 0; i < 30; ++i)
            {
                // minimumra hozzás
                if (array[i] < min)
                {
                    min = array[i];
                    minIdx = i;
                }

                //maximumra hozzás
                if (array[i] > max)
                {
                    max = array[i];
                    maxIdx = i;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrtask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, };
            int i, j, single = 0;

            for (i = 0; i < arr1.Length; i++)
            {
                for (j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    single++;
                }
            }
            Console.WriteLine("Unique Number: " +single);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            int i, j, duplicate = 0;

            for (i = 0; i < arr1.Length; i++)
            {
                for (j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j]) ;
                }
            }
            Console.WriteLine("Duplicate Number: "+duplicate);
            Console.ReadKey();

        }
    }
}

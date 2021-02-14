using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2 };
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine(" array: ");
            for(int i = 0; i < arr1.Length; i++)
            { 
            Console.Write(arr1[i] + " ");
            }
        
            Console.WriteLine();

            Console.WriteLine("new arry: ");

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        Console.ReadKey();
        }

    }
}

using System;

using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int even = 0, odd = 0;

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    even += i;
                }
                else
                {
                    odd += i;
                }

            }

            Console.WriteLine(even);
            Console.WriteLine(odd);

            Console.ReadKey();
        }
        }
    }


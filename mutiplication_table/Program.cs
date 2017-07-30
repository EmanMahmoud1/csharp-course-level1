using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiplication table for odd number
            int mul = 0;
            for (int i = 1; i < 13; i+=2)
            {
                Console.WriteLine("\n");
                for (int j = 1; j <= 12; j+=2)
                {
                    mul = i * j;
                    Console.WriteLine("     {0}*{1}={2}     ", i, j, mul);
                }
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 11, v2 = 0;
            if (v1 >= 2)
            {
                Console.WriteLine("your Variable greater than or equals 2");
                // nested if inside another if.
                if (v2 < 7)
                {
                    Console.WriteLine("v1>=2      v2<7");
                }
                    else
                    {
                    Console.WriteLine(" v1>=2      v2>=7");
                    }
            }
            else
            {
                Console.WriteLine("your variable less than2");
            }
            Console.ReadKey();
        }
    }
}

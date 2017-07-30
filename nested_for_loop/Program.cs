using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 1,coulmnnumber=3,temp1=0;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("\n");
                for (int j = temp; j < coulmnnumber + temp; j++)
                {
                    Console.Write("    {0}    ", j);
                    temp1 = j+1;
                }
                temp = temp1;
            }
            Console.ReadKey();
        }
    }
}

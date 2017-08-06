using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_2
{
    class Program
    {
        
        static void add(int num1, int num2)
        {
            int temp = num1 + num2;
            Console.WriteLine("your summation equal {0}",temp);
        }
        static void Main(string[] args)
        {
            int var1 = 2, var2 = 8;
            add(var1, var2);
            Console.ReadKey();
        }
    }
}

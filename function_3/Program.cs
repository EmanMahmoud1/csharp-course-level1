using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_3
{
    class Program
    {
        static int add(int num1, int num2)
        {
            int temp = num1 + num2;
            return temp;    
        }
        static void Main(string[] args)
        {
            int var1 = 2, var2 = 8;
         int  sum= add(var1, var2);
         Console.WriteLine("your summation equal  {0}  ",sum);
            Console.ReadKey();
        }
    }
}

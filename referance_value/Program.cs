using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referance_value
{
    class Program
    {
        static void multiplier(ref int a1,ref int a2)
        { 
            a2=a1*3;
            a1 += 19;
            Console.WriteLine("the first number = {0} the second number = {1} ",a1,a2);
        }
        static void Main(string[] args)
        {
            int num1 = 12,num2=3;
            Console.WriteLine("your first number is {0} &your second number {1},",num1,num2);
             multiplier(ref num1,ref num2);
            Console.WriteLine("your first number is {0} &your second number {1}", num1,num2);
            Console.ReadKey();
        }
 
    }
}

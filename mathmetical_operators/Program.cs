using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mathmetical_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 7;
            int var2 = 2;
            int temp8 = var1-- / var2;
            int temp1 = var1 + var2;// addition expression 
            int temp2 = var1 - var2;// subtraction expression
            int temp3 = var1 * var2;// multiplication ~
            int temp4 = var1 / var2;// division
            int temp5 = var1 % var2;// reminder
            int temp6 = ++var1;//increment then transfer
            int  temp6_1 = var1++;//transfer then increment;
            int temp7 = --var2;// decrement th transfer
            int temp7_1 = var2--;//transfer then decrement
            

            Console.WriteLine ("sum={0}\nsub={1}\nmultiply={2}\ndivision={3}\n the remaining part of division={4}\n ",temp1,temp2,temp3,temp4,temp5);
            Console.WriteLine(" increment of the first num is {0} decrement of the second num is {1}",temp6,temp7);
            Console.WriteLine("transfer then increment{0} transfer the decrement{1}", temp6_1, temp7_1);
            Console.WriteLine("var1={0}            var2={1}",var1,var2);
            Console.WriteLine("\nthe result is {0}",temp8);
            Console.ReadKey();


        }
    }
}

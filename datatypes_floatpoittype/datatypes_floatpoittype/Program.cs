using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datatypes_floatpoittype
{
    class Program
    {
        static void Main(string[] args)
        {
            //to determin the minimum and maximum value of the flaot 
            float min = float.MinValue; float max = float.MaxValue;
            Console.WriteLine("the min value  {0},the max value is {1}",min,max);

            //to determin the minimum and maximum value of the double

            double min1 = double.MinValue; Double max1 = double.MaxValue;
            Console.WriteLine("the min value  {0},the max value is {1}",min1,max1);

            float fvar = 1f / 3; //float number
            double dvar = 1d / 3;//double number
            decimal devar = 1m / 3;//decimal number
            Console.WriteLine("the division of 1 by 3 of the float number is {0}\n the division of 1 by 3 of the double number is {1} \n the division of 1 by 3 of the decimal number is {2}\n  ", fvar, dvar, devar);



            Console.ReadKey();







        }
    }
}

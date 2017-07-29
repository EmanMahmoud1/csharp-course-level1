using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boolean_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean output;
            int v1=5,v2=3;
            output=v1==5;// check if v1=5 or not
            output = v1 != 5;// check if v1 not equal to 5.
            output = v1 < 10;// check if smaller than 10.
            output = v1 > 5;// check if greater than 5.
            output = v1 <= 5;// check if smaller than or equal.
            output = v1 >= 5;// check if greater than or equal
            output = (v1 == 5) && (v2==3);// check if v1=5 and v2=3 in the same time.
            output = (v1 == 5) ||(v2>4);// check if v1=5 or v2>4 

            Console.WriteLine("your result is {0}",output);
            Console.ReadKey();
        }
    }
}

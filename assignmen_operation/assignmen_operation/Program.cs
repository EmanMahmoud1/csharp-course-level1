using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignmen_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 7, v2 = 2;
            

            v1 = v2;//assign the value of variable 2 to variable 1.
            v1 += v2;//v1=v1+v2;
            v1 -= v2;//v1=v1-v2;
            v1 *= v2;//v1=v1*v2;
            v1 /= v2;//v1=v1/v2;
            v1 %= v2;//v1=v1/v2;
            Console.WriteLine("your result {0}",v1);
            int f1 = 7, f2 = 2;
            f1 /= ++f2;
            Console.WriteLine("your result {0}", f1);
            Console.ReadKey();

        }
    }
}

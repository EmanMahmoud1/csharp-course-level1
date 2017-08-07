using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Program
    {
        //2 function with the same name and different function type and parameters.
        public static int printnumber(int mynumber)
        {
            return mynumber;
        }
        public static double printnumber(double mynumber)
        {
            return mynumber;
        }
        static void Main(string[] args)
        {
          int num=6;
            Console.WriteLine(printnumber(num));
            Console.ReadKey();
        }
    }
}

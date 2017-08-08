using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace debbug_trace
{
    class Program
    {
        public static int addfubction(int x, int y)
        {
           Debug. WriteLine("beginning of add function");
            int sum = x + y;
            Debug.WriteLine("end of add function");

            return sum;
        }
        public static int mulfunction(int x, int y)
        {
            Debug.WriteLine("beginning of mul function");

            int mul = x*y;
            Debug.WriteLine("end of mul function");

            return mul;

        }
        public static void printfunction(int z)
        {
            Trace.WriteLine("start of write function");
            WriteLine($" your result{z}");
            Debug.WriteLine("end of write function");
        }
        static void Main(string[] args)
        {
            int a = 10, b = 12;
            int s = addfubction(a, b);
            int m = mulfunction(a,b);
            printfunction(s);
            printfunction(m);
            ReadKey();
        }
    }
}

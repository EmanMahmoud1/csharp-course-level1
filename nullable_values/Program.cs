using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace nullable_values
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = null;
            int? num = null;
            double? num2 = null;
            WriteLine($"your null string value equal {mystring}");
            WriteLine($"your null integer value equal {num}");
            WriteLine($"your null double value equal {num2}");


            ReadKey();

        }
    }
}

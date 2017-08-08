using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;


namespace assertion_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter your value");
            int i = Convert.ToInt32(ReadLine());
            if ( i>= 100)
            {
                WriteLine($"{i}");
            }
            else
            {
               // Debug.WriteLine("we are here");
                Debug.Assert(i>=100,"account failure","your accout must be greater than 100");
                //Trace.Assert(i >= 100, "short", "long");

            }
            WriteLine("Done");
            ReadKey();
        }
    }
}

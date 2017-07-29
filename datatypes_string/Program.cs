using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datatypes_string
{
    class Program
    {
        static void Main(string[] args)
        {
           //this program to find the min and max value of character and print q at the console window
            int chairmin = char.MinValue; int chairmax = char.MaxValue;
           char ss='a';
            int charvalue='a';// to find the integer value related to character f.
            char va1 = Convert.ToChar(charvalue);
            Console.WriteLine("the char min value={0}\n the char max value={1}\n the char you entered ={2},char integer value={3}\n converted value  {4}",
                chairmin,chairmax,ss,charvalue,va1);
            //string definition
            string mystring="huda taha";
            Console.WriteLine("\nyour string is {0}",mystring);

            //boolean definition
            bool b1 = false;
            Console.WriteLine("your boolean number equal {0}",b1);

            Console.ReadKey();

        }
    }
}

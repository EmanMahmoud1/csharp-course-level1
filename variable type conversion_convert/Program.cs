using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_type_conversion_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1 = 213400.66d;
            string st1, substring;
           /// st1 = d1; //implicit conversion                           error
          /// st1=(string)d1; //explicit conversion                      error
            st1 = Convert.ToString(d1);
            substring = st1.Substring(0,5);
            Console.WriteLine("your double number = {0}",d1);
            Console.WriteLine("your string number = {0}", st1);         
            Console.WriteLine("your substring number = {0}",substring);

            Console.ReadKey();

        }
    }
}

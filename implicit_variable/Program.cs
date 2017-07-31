using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicit_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            long v1 = 1000;
            float v2 = v1;
            float f = 9f;
            // long l = f;              //Error	1	Cannot implicitly convert type 'float' to 'long'. 
            //An explicit conversion exists (are you missing a cast?)	
            Console.WriteLine("{0}",v2);
            char c='f';
            int d = c;
            Console.WriteLine("{0}",d);
            Console.ReadKey();
        }
    }
}

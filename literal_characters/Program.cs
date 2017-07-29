using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace literal_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = -100;
            uint v2 = 1000u;// V2=100 it's also ok, if v2=-100 it will be an error.
            long v3 = 199L;// v3=199l(l small) also ok; 
            ulong v4 = 100000;// v4=1000u also ok;v4=10000lalso ok;v4=1000lu also ok; v4=10000ul;
            Console.WriteLine("{0} {1} {2} {3}",v1,v2,v3,v4);
            float f1 = 1.5f;
            double d1 = 100.4;
            decimal de1 = 100.55m;
            Console.WriteLine("float{0} double {1} decimal {2}", f1, d1, de1);
            // new method in new version Console.WriteLine($"{f1},{d1},{de1}");
            Console.ReadKey();

        }
    }
}

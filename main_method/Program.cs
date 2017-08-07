using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_method
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("the argument length = {0}",args.Length);
            foreach(string str in args )
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
            return 0;
        }
    }
}

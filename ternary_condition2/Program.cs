using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary_condition2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "nada", myname;
            // name.Equals("nada")   and    name=="nada" work the same 
           // myname=(name.Equals("nada"))?"your name is Nada":"your name is Huda";
            myname = (name=="nada") ? "your name is Nada" : "your name is Huda";
            Console.WriteLine("************{0}***********",myname);
            Console.ReadKey();
        }
    }
}

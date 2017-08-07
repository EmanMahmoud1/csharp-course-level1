using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_function
{
    class Program
    {
        struct fullname
        {
            public string firstname, lastname;
        }
        static void Main(string[] args)
        {
            fullname name;
            name.firstname = "eman";
            name.lastname = "abd elhaleim";
            Console.WriteLine("{0}  {1}",name.firstname,name.lastname);
            Console.ReadKey();
        }
    }
}

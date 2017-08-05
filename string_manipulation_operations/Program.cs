using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_manipulation_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "i am smart";
            char[] mychararray = mystring.ToCharArray();
            Console.WriteLine("your string length is {0}", mystring.Length);
            foreach (char mychar in mychararray)
            {
                Console.WriteLine(mychar);
            }
            Console.ReadKey();
        }
    }
}

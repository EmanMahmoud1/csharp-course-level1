using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upper_lower_trim_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring, mystring2, mystring3, mystring4, mystring5, mystring6,mystring7;
            Console.WriteLine("enter your string");
            char[] mychar = {'e','h','i',' '};//if i want to trim this letters at the beginning and the end from mystring.
            mystring = Console.ReadLine();
            mystring2 = mystring.ToUpper();// make all chars upper case.
            mystring3 = mystring.ToLower();// make all chars lower case
            mystring4 = mystring.TrimStart(mychar);// cut spaces before and after sentence.
            mystring5=mystring.TrimEnd(mychar);
            Console.WriteLine(mystring2);
            Console.WriteLine(mystring3);
            Console.WriteLine(mystring4);
             Console.WriteLine(mystring5);



            Console.ReadLine();
        }
    }
}

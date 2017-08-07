using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_definition
{
    delegate int mynewnumber(int num);
    class Program
    {
        static int mynum = 3;
        static int addfunction(int number)
        {
            mynum += number;
            return mynum;
        }
        static int mulfunction(int number)
        {
            mynum *= number;
            return mynum;
        }
        static void Main(string[] args)
        {
            mynewnumber n1 = new mynewnumber(addfunction);
            mynewnumber n2 = new mynewnumber(mulfunction);
            n1(5);
            Console.WriteLine(mynum);
            n2(5);
            Console.WriteLine(mynum);


            Console.ReadKey();

        }
    }
}

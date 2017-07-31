using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicit_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyte1,sbyte2;
            int int1 = 25,int2=500;
            // sbyte1 = int1;      Error	1	Cannot implicitly convert type 'int' to 'byte'.
            //An explicit conversion exists (are you missing a cast?)	

            //type1=(type1)type2
            sbyte1=(sbyte)int1;
            sbyte2=(sbyte)int2;
            Console.WriteLine("your integer variable = {0}", int1);
            Console.WriteLine("your byte variable = {0}",sbyte1);
            Console.WriteLine("your overflow variable = {0}", int2);           
            Console.WriteLine("youroverflow byte  variable = {0}",sbyte2);



            Console.ReadKey();

        }
    }
}

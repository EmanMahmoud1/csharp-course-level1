using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exiplicit_variable_checked_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyte1, sbyte2;
            int int1 = 25, int2 = 500;
            // sbyte1 = int1;      Error	1	Cannot implicitly convert type 'int' to 'byte'.
            //An explicit conversion exists (are you missing a cast?)	

            //type1=(type1)type2
            sbyte1 = checked((sbyte)int1);
            sbyte2 = unchecked((sbyte)int2);// to ignore overflow exception
            Console.WriteLine("your integer variable = {0}", int1);
            Console.WriteLine("your byte variable = {0}", sbyte1);
            Console.WriteLine("your overflow variable = {0}", int2);
            Console.WriteLine("youroverflow byte  variable = {0}", sbyte2);

            decimal dec1, dec2;
            int i1 = 488, i2=999999999;
            dec1 = i1;
            dec2 =i2;
            Console.WriteLine("{0}             {1}",dec1,dec2);

            Console.ReadKey();
        }
    }
}

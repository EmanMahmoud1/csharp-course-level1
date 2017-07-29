using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            // HOW to use if and else if statment
            int v1=10,v2=14;
            if (v1 <= 2 && v2 >= 2)
            {
                Console.WriteLine("the first condition is true");
            }
            else if (v1<=2 || v2>=13)
            {
                Console.WriteLine("the second condition is true");
            }
            else if (v2 == 12)
            {
                Console.WriteLine("the third condition is true");

            }
            else
            {
                Console.WriteLine("try again");
            }

            Console.ReadKey();
    
        }
    }
}

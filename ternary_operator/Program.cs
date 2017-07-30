using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ternary condition 
            // output=(v1==50)? first condition    
            //"your number =50" second condition   
            //your number not equal 50  third condition

            int v1 = 20;
            string  output=(v1==50)? "your number =50":"your number not equal 50";
            int x = (v1 >= 50) ?100 : 0;
            Console.WriteLine("your string = {0}  ",output);
            Console.WriteLine("your integer = {0}",x);
            Console.ReadKey();
        }
    }
}

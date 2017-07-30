using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            float salary = 200f, total= 0f;
            int i=0;
            do {
                total=salary+total;// add salary with toatal.
                 i++;//increment the value of i each turn
                Console.WriteLine("the value of i =  {0}",i);
            
            }while(i<10);
            Console.WriteLine("your salary through 10 month {0}",total);
            Console.ReadKey();
        }
    }
}

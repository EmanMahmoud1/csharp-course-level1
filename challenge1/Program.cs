using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary_now = 1020, salary_final = 2000,salary=salary_now;
            int i = 0;
            do
            {
                salary += 20;
                i++;
                //Console.WriteLine("the number of monthes{0}", i);

            } 
            while (salary<salary_final);
            Console.WriteLine("the number of monthes{0}", i);
            Console.WriteLine("the final salary{0}", salary);

            Console.ReadKey();
        }
    }
}

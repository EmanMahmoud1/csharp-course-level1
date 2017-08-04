using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
             int array_size;
            // 3 different forms of array definition.
            Console.WriteLine("enter your array size");
            array_size=Convert.ToInt16(Console.ReadLine());
            int [] numbers2=new int [array_size];
            for (i = 0; i <array_size;i++ )
            {
                Console.WriteLine("enter the value of matrix number {0}",i+1);
                numbers2[i]=Convert.ToInt16(Console.ReadLine());
               // Console.WriteLine(numbers2[i]);
            }
            // the following lines to print all elements except the end.
            i = 0;
            foreach(int item in numbers2)
            {
                Console.WriteLine(item);
                i += 1;
                if (i == array_size - 1) 
                break;

            }
            Console.ReadKey();
       
        }
    }
}

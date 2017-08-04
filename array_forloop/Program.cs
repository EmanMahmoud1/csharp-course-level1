using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0,max;
            const int array_size = 5;
            // 3 different forms of array definition.
            int myarray_size = 5;
            int[] numbers = {1,2,7,4,135};
            int [] numbers2=new int [myarray_size];
            int[] numbers3 = new int[array_size] { 1, 2, 3, 4, 5 };
            max = numbers[0];
            for (i = 0; i <array_size;i++ )
            {
                if(max<=numbers[i]) 
                {
                max=numbers[i];
                }
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("your maximum is {0}", max);
            Console.ReadKey();
        }
    }
}

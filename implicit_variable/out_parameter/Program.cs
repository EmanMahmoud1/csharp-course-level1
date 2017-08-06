using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_parameter
{
    class Program
    {
        static int minval(int[] my_array1,out int myindex)
        {
            //this function to calvculate the min value
            int minva2 = my_array1[0];
            myindex = 0;
            for (int i = 0; i < (my_array1.Length); i++)
            {
                if (minva2 > my_array1[i])
                {
                    minva2 = my_array1[i];
                    myindex=i;
                }
            }

            return minva2;
        }
        static int maxval(int[] my_array1)
        {
            //this function to calvculate the max value
            int maxva2 = my_array1[0];
            for (int i = 0; i < (my_array1.Length); i++)
            {
                if (maxva2 < my_array1[i])
                {
                    maxva2 = my_array1[i];
                }
            }

            return maxva2;
        }
        //this function calculate the  average value
        static int avr_val(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < (array.Length); i++)
            {
                sum += array[i];

            }
            int avg1 = sum / array.Length;
            return avg1;
        }

        static void Main(string[] args)
        {
            int index;
            int[] array = new int[6] { 762, 4, 487, 212, 45433, 548 };
            int minval1 = minval(array,out index);
            int maxval2 = maxval(array);
            int avg = avr_val(array);
            Console.WriteLine("your min value is {0} and the index value = {1}", minval1,index);
            Console.WriteLine("your max value is {0}", maxval2);
            Console.WriteLine("your average value is {0}", avg);


            Console.ReadKey();

        }
    }
}

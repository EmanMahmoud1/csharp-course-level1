using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the array of two elements
            int[][] arr = new int[4][];
            //initialize the element
            arr[0] = new int[5] { 1,2,3,4,5};
            arr[1] = new int[4] {1,2,3,4};
            arr[2]=new int [8] {1,2,3,4,5,6,7,8};
            arr[3]=new int [2]{9,5};
            //display the array elements
            Console.WriteLine("the arr length {0} ",arr.Length);

            for (int i = 0; i < arr.Length;i++)
            {
                Console.Write("element({0})\t",i);
                for (int j = 0; j < arr[i].Length; j++) 
                {
                    Console.Write("{0}", arr[i][j] + "\t");
                };
                Console.WriteLine();

            };
            Console.ReadKey();
        }
    }
}

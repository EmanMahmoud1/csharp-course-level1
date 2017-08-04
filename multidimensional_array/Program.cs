using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers1 ={                                                                           //definition1

                                {1,2,3,4},
                                {3,2,4,5},
                                {6,12,55,6}
                            };
            string[,] names = new string[,] {                                               //definition 2
            
            {"taha","huda","nada"},{"eman","mahmoud","abdo"}
            
            };
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4;j++ )
                {
                    Console.Write(numbers1[i,j] + "\t");

                };
                Console.Write("\n");

            };
           
            Console.ReadKey();
            

        }
    }
}

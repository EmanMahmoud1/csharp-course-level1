using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_scope_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            // THIS CODE WILL HAVE AN ERROR IN WORD INDEX
            //int i = 0;
            //for (i = 0; i < 4; i++)
            //{
            //    int index = i;
            //    Console.WriteLine(index);
            //}
            //Console.WriteLine(index);

            //Console.ReadKey();
            int i = 0,index=0;
            for (i = 0; i < 4; i++)
            {
                index = i;
                Console.WriteLine(index);
            }
            Console.WriteLine(index);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int array_size;
            Console.WriteLine("enter your array size");
            array_size = Convert.ToInt16(Console.ReadLine());
            string[] my_children_names = {"TAHA","HUDA","NADA" };
            my_children_names[2] = "mahmoud";//to change the third element in an array 
            int length_1 = my_children_names.Length;// to define the length of array.
            string[] names=new string [array_size];
            for(int i =0;i<length_1;i++)
            {
                Console.Write(my_children_names[i]+"\t");// to print array element in yhe same line.
            }
            Console.ReadLine();
        }
    }
}

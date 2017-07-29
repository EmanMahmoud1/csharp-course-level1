using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            string mychildren="nada";
            // switch syntax
            switch (mychildren)
            {
                    //every case has it's break
                case "taha":
                    Console.WriteLine("your baby is taha");
                    break;
                case "huda":
                    Console.WriteLine("huda");
                    break;
                case "nada":
                    Console.WriteLine("nada");
                    break;
                default:
                    Console.WriteLine("no one enter");
                    break;
            }
            Console.ReadKey();
        }
    }
}

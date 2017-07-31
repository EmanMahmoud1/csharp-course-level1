using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname;
            int myage, myweight, myheight, mygrade;// choose grade from A OR B OR C OR D
            Console.WriteLine("Enter your name");
            myname=Console.ReadLine();
            Console.WriteLine("Enter your age");
            myage =Convert.ToInt32( Console.ReadLine());
           Console.WriteLine("Enter your weight");
           myweight =Convert.ToInt32( Console.ReadLine());
           Console.WriteLine("Enter your height");
           myheight =Convert.ToInt32( Console.ReadLine());
           Console.WriteLine("enter your grade");
           mygrade = Console.Read();
           char a = Convert.ToChar(mygrade);

            Console.WriteLine("your name is   {0} \n your age is {1} \n your weight is {2} \n your height is {3}  ",myname,myage,myweight,myheight);
            Console.WriteLine("your grade is  {0}  ",mygrade);
            Console.WriteLine("your grade is  {0}  ", a);

            Console.ReadKey();

        }
    }
}

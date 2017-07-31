using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empolyee_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, secondname, salary1, taxrate1;
            decimal salary,taxrate;
            int i=0;
            decimal total=0,total_tax=0;
            Console.WriteLine("Enter your First name");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter your Second name ");
            secondname = Console.ReadLine();
            Console.WriteLine("Enter your monthly salary ");
            salary1= Console.ReadLine();
            salary = Convert.ToDecimal(salary1);
            Console.WriteLine("Enter your tax rate");
            taxrate1 = Console.ReadLine();
            taxrate = Convert.ToDecimal(taxrate1);
            do
            {
                total += salary;
                i += 1;

            }while (i<12);
            total_tax=total-(taxrate * total);// m for decimal
            Console.WriteLine("Welcome  {0} {1}",firstname,secondname);
            Console.WriteLine("your net salary is {0} $",total);
            Console.WriteLine("your salary after tax is {0} $",total_tax);
            Console.WriteLine("Good Bye");
            Console.ReadKey();
        }
    }
}

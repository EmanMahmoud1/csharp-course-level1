using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace paramsReferances
{
    class Program
    {
        static double CalculateAverage(params double[] values)
        {
            WriteLine("you send to me {0} double values",values.Length);
            double sum = 0,avg;
            if (values.Length == 0)
            {
                return sum;
            }

            foreach (double num in values)
                {
                sum += num;

            }
            avg = sum / values.Length;

            
            return avg;
        }




        static void Main(string[] args)
        {
            double average;
            average = CalculateAverage(2.4,5,8.65,8);
            WriteLine($"the average equal {average}");

            double [] average1= {2.3,4,5,6,6.1 };
            double average11 = CalculateAverage(average1);
            WriteLine($"the average equal {average11}");
            double average2;
            average2 = CalculateAverage();
            WriteLine($"the average equal {average2}");
            ReadKey();
        }
    }
}

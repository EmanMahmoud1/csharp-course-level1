using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
            //METHOD ONE
        {
            //  WriteLine(DateTime.Now.ToString("hh:mm:ss\nMM dd yyyy"));

            //METHED TWO

            //DateTime time = DateTime.Now;
            //// mm minutes,MM monthes, MMM month name, ddd day name, hh 2char for hour /12 hour.
            ////HH HOUR /24 HOUR.
            ////yyyy YEAR dd 2 char for day 
            //string format = "MMM  ddd MM dd yyyy hh:mm";
            //WriteLine(time.ToString(format));


            //DIFFERENT FORMATS TO TIME

            //DateTime now = DateTime.Now;
            //WriteLine(now.ToString("d"));
            //WriteLine(now.ToString("D"));
            //WriteLine(now.ToString("f"));
            //WriteLine(now.ToString("F"));
            //WriteLine(now.ToString("m"));
            //WriteLine(now.ToString("M"));
            //WriteLine(now.ToString("g"));
            //WriteLine(now.ToString("G"));
            //WriteLine(now.ToString("o"));
            //WriteLine(now.ToString("O"));
            //WriteLine(now.ToString("s"));
            //WriteLine(now.ToString("t"));
            //WriteLine(now.ToString("T"));
            //WriteLine(now.ToString("u"));
            //WriteLine(now.ToString("U"));
            //WriteLine(now.ToString("y"));
            //WriteLine(now.ToString("Y"));


            ////USE SPACE AFTER S TO AVOID ONE CHAR FORMAT.
            //DateTime now = DateTime.Now;
            //string result = now.ToString("s ");
            //WriteLine($"{now} [s]={result}");


            //to show days begin with the current day;
            DateTime now = DateTime.Today;
            for (int i=0;i<7;i++)
            {
                WriteLine(now.ToString("dddd"));
                now = now.AddDays(1);
            }
            ReadKey();
        }
    }
}

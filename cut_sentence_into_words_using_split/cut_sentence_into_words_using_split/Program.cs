using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cut_sentence_into_words_using_split
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring;
            char[] seperator = {' '};
            Console.WriteLine("enter your sentence");
            mystring = Console.ReadLine();
            string[] mywords;
            mywords = mystring.Split(seperator);
            foreach(string word in mywords)
            {
            
            Console.Write(word+"    ");
            
            }
            Console.ReadKey();
        }
    }
}

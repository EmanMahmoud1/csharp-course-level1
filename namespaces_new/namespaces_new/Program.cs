using static System.Console;
using ob = mybrothers.oldbrothers.brothers;//
//using mybrothers.youngbrothers;
//using static mybrothers.youngbrothers.mygbrothers; //if call class also
using yb = mybrothers.youngbrothers.brothers; //if use alias name.





namespace operation_on_namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("those are my family");
            // myyoungbrothers.print();
           yb. print();
           ob. print();
            ReadKey();

        }

    }
}
                                              
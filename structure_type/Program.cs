using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure_type
{
    class Program
    {
        enum toyota :byte
        {
           RAV4=1,
            camery=2,
            tundra=3,
            highland=4
            }
        enum orientation : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }
        struct cartype
        {
            public toyota modelname;
            public double modelyear;
        }
        struct distance
        {
            public orientation ori_name;
            public double distance_destination;
        }
        static void Main(string[] args)
        {
            cartype mycartype;
            int cartype ;
            double modelyear;
            Console.WriteLine("1)RAV4\n2)camery\n3)tundra\n4)highland");
            
            do
            {
            Console.WriteLine("enter your car type");
                cartype=Convert.ToInt32(Console.ReadLine());
            }while(cartype<1||cartype>4);
            Console.WriteLine("enter a model year:");
            modelyear = Convert.ToDouble(Console.ReadLine());
            mycartype.modelname=(toyota)cartype;
            mycartype.modelyear = modelyear;
            Console.WriteLine("my car type is {0} and the model year is {1} ",mycartype.modelname,mycartype.modelyear);

            distance mydistance;
            double distance;
            double distance_destination;
            Console.WriteLine("1)north\n2)south\n3)east\n4)west");
            do
            {
                Console.WriteLine("enter your car orientation");
                distance = Convert.ToInt32(Console.ReadLine());
            } while (distance < 1 || cartype > 4);
            Console.WriteLine("enter a distance year:");
            distance_destination = Convert.ToDouble(Console.ReadLine());
            mydistance.ori_name = (orientation)distance;
            mydistance.distance_destination = distance_destination;
            Console.WriteLine("my orientation is {0} and the distance will be {1} ", mydistance.ori_name, mydistance.distance_destination);
            Console.ReadKey();
     }
    }
}

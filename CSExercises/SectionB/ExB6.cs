using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string x1string = Console.ReadLine();
            double inputx1double = Convert.ToDouble(x1string);
            string y1string= Console.ReadLine();
            double inputy1double = Convert.ToDouble(y1string); 
            string x2string = Console.ReadLine();
            double inputx2double = Convert.ToDouble(x2string); 
            string y2string = Console.ReadLine();
            double inputy2double = Convert.ToDouble(y2string);
            CalculateDistance(inputx1double, inputy1double, inputx2double, inputy2double);
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE

            double Distance = System.Math.Sqrt((x2 - x1)*(x2-x1) + (y2-y1)*(y2-y1));
            Console.WriteLine(Distance);
            return 0;
        }
    }
}

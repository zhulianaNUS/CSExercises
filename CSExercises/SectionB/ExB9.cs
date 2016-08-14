using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string inputString = Console.ReadLine();
            double inputdouble = Convert.ToDouble(inputString);
            CalculateFare(inputdouble);
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double D = (2.40 + (distance * 0.4));           
            Console.WriteLine(Math.Ceiling(D * 10) / 10);     
            return 0;

        }
    }
}

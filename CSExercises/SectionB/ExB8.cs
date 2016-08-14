﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
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
            Console.WriteLine( Math.Round(D,1));
            return 0;

        }
    }
}

using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string astring = Console.ReadLine();
            double inputadouble = Convert.ToDouble(astring);
            string bstring = Console.ReadLine();
            double inputbdouble = Convert.ToDouble(bstring);
            string cstring = Console.ReadLine();
            double inputcdouble = Convert.ToDouble(cstring);
            CalculateArea(inputadouble, inputbdouble, inputcdouble);
        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            double s = (a + b + c) / 2;
            double Area = System.Math.Sqrt(s *(s - a)*(s - b)*(s - c));
            Console.WriteLine(Area);
            return 0;
        }
    }
}
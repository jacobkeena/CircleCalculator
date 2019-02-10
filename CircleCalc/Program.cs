using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Are you calculating area or circumference of a circle?");
            Console.WriteLine("For Area            press 1");
            Console.WriteLine("For Circumference   press 2");

            double pie = Math.PI;
            double Area, Cir;
            double result;

            if (double.TryParse(Console.ReadLine(), out result))
            {
                if (result == 1)
                {
                    Console.WriteLine("Area, got it. Please enter the radius of the circle");
                    double result2;
                    double.TryParse(Console.ReadLine(), out result2);
                    double areaRadius = result2;
                    Area = pie * (areaRadius * areaRadius);
                    //result = Area;
                    Console.WriteLine("The Area is    " + Area);
                    Console.ReadLine();
                }
                if (result == 2)
                {
                    Console.WriteLine("Circumferene, great! Please enter the radius of the circle");
                    double result3;
                    double.TryParse(Console.ReadLine(), out result3);
                    double cirRadius = result3;
                    Cir = 2 * pie * cirRadius;
                    // result = calcCirc(cirRadius);
                    Console.WriteLine("The Circumference is    " + Cir);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That wasn't an option, please press 1 or 2 and press enter");
                    goto Start;
                }
            }
        }

        //static double calcArea(double Area) //method to calculate Area
        //{
        //   return Area;
        //}
        //static double calcCirc(double Cir) //method to calculate Cir
        //{
        //    return Cir;
        //}
    }
}


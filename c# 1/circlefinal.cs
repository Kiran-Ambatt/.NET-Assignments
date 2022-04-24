/* 5.	Write a single method that calculates the area and circumference of the circle. The area and circumference should be displayed through the client code */
using System;

namespace MyApplication
{
    class Areaa
    {
        static void circleeee(double r)
        {
            double AREA;
            const double PI = 3.14;
            AREA = PI * r * r;
            Console.WriteLine("\nThe area of circle is {0} when radius is {1}", AREA, r);
            Console.WriteLine("\nThe circumference of circle is {0}", 2 * PI * r);
        }

        static void Main(string[] args)
        {
            circleeee(3);
        }
    }
}
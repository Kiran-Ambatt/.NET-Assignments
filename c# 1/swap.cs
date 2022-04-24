/* 4.	Write a method to swap two integers. The client code should call the method and print the swapped value.  */
using System;

namespace MyApplication
{
    class Program
    {
        static void swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values: {0} {1} ", a, b);
        }

        static void Main(string[] args)
        {
            swap(2, 3);
        }
    }
}
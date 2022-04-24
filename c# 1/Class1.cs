/* 3.	Write a static method to accept param array of integers. The method should find the sum of all the integers passed and display the result. Write a client program to call the method.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
        class hello
        {
            public void sum(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array[i];
                }   
                Console.WriteLine(sum);
            }
        public static void custom()
        {
            Console.WriteLine(100);
        }

        }
}


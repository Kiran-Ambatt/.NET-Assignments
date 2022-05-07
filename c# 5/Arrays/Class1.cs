using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Array
    {
        
        public static int[] myarray = new int[5] { 1, 8, 3, 2, 5 };
        public static int[] copyofarray = new int[5];
        public static string[] myarraystring = new string[5] { "hello", "man", "how", "are", "you", };
        public static void Main()
        {
            Console.WriteLine("Before sorting array is");
            System.Array.ForEach(myarray, Console.WriteLine);
            Console.WriteLine($"{string.Join(", ", myarraystring)}");
            System.Array.Sort(myarray);
            Console.WriteLine("After sorting array is");
            System.Array.ForEach(myarray, Console.WriteLine);
            System.Array.Copy(myarray, 0, copyofarray,0, 5);
            Console.WriteLine("the copied array is:");
            System.Array.ForEach(copyofarray, Console.WriteLine);
            Console.WriteLine("the cleared array is:");
            System.Array.Clear(copyofarray);
            System.Array.ForEach(copyofarray, Console.WriteLine);
            Console.WriteLine("the reversed array is:");
            System.Array.Reverse(myarray);
            System.Array.ForEach(myarray, Console.WriteLine);

        }
        
    }

}

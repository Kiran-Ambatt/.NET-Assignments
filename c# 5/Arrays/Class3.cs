using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Class3
    {
        public static void Main()
        {
            LinkedList<string> employee = new LinkedList<string>();
            //Console.WriteLine("Number of students: {0}",
            //my_list.Count);
            employee.AddLast("kiran");
            employee.AddLast("Rajesh");
            employee.AddLast("Mahima");
            employee.AddLast("salomi");
            Console.WriteLine("Number of employees: {0}", employee.Count);
            foreach(string item in employee)
            {
                Console.WriteLine(item);
            }

        }
        

    }
}

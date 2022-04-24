/* 2.	Accept average marks of five students. Display the highest marks obtained. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgMarksOfStudent
{
    class HighestMark
    {
        public int[] marks = new int[5];
        public int highest = 0;
        public void getAvgMarks()
        {
            // initialize variable for total students
            int totalStudents = 5;
            Console.WriteLine("Enter average marks of {0} students\n", totalStudents);

            // loop through each student and get the average mark from the console
            for (int i = 0; i < totalStudents; i++)
            {
                Console.WriteLine("Enter the mark of student {0}", i+1);

                // assign this to class property
                this.marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public int calculateHighestMark()
        {
            for (int i = 0; i < this.marks.Length; i++)
            {
                this.highest = (this.marks[i] > this.highest) ? this.marks[i] : this.highest;
            }
            return this.highest;
        }
        static void Main()
        {
            // create class instance
            HighestMark HighestMarkObj = new HighestMark();

            // read average mark of students
            HighestMarkObj.getAvgMarks();

            // calculate the highest mark among students
            int high = HighestMarkObj.calculateHighestMark();

            // print the highest mark
            Console.WriteLine("Highest mark: " + high);
        }
    }
}

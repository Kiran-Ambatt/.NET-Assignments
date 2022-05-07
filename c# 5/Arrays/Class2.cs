using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArrayHelper
    {
        public static void Main()
        {
            
            ArrayList employee1=new ArrayList();
            employee1.Add("kiran");
            employee1.Add(1000);
            employee1.Add(252);
            employee1.Add("developer");

            ArrayList employee2 = new ArrayList() { "helen", 50000, 656, "tester" };

            foreach(var item in employee1)
            {
                Console.WriteLine(item+",");
            }
            foreach (var item in employee2)
            {
                Console.WriteLine(item + ",");
            }
            

        }
    }
}


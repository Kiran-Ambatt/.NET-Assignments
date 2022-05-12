using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void display()
        {
            Console.WriteLine("User name is: {0}",Name);
            Console.WriteLine("User Id is:{0}", Id);
        }

        static void Main()
        {
            User user = new User(5, "kiran");
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] type = assembly.GetTypes();
            user.display();
            foreach (var item in type)
            {
                Console.WriteLine(item.Name);
                MethodInfo[] m = item.GetMethods();

                foreach (var items in m)
                {
                    Console.WriteLine(items.Name);
                }
            }
            Console.ReadLine();
        }
    }
        
}

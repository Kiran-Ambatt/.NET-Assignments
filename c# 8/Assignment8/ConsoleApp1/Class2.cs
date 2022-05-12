using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace Reflection2
{
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Constructor |
    AttributeTargets.Property, AllowMultiple = true)]
    class SoftwareAtttribute : System.Attribute
    {
        private string ProjectName;
        private string Description;
        private string ClientName;
        private string StartedDate;
        private string EndDate;



        public string projectName
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        public string clientName
        {
            get { return ClientName; }
            set { ClientName = value; }
        }
        public string startedDate
        {
            get { return StartedDate; }
            set { StartedDate = value; }
        }
        public string endDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }
        public class HDFCAccount : SoftwareAtttribute
        {
            public void displayAccount(string projectName, string description, string clientname, string startdate, string enddate)
            {



                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                this.startedDate = startdate;
                this.EndDate = enddate;
                Console.WriteLine("project description : " + Description);
                Console.WriteLine("project name : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);
                Console.WriteLine("Project Started Date : " + startedDate);
                Console.WriteLine("Project End Date :" + EndDate);



            }
        }



        public class ICICIAccount : SoftwareAtttribute
        {
            public void displayAccount(string description, string projectName, string clientname, string startdate, string enddate)
            {



                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                this.startedDate = startdate;
                this.EndDate = enddate;
                Console.WriteLine("\nProject Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);
                Console.WriteLine("Project Started Date : " + startedDate);
                Console.WriteLine("Project End Date :" + EndDate);
            }
        }



        class Test
        {
            static void Main(string[] args)
            {
                HDFCAccount ha = new HDFCAccount();
                ha.displayAccount("Email managemnt system using React JS", "Email management system", "SAP", "24-01-2023", "25-03-2023");
                ICICIAccount ia = new ICICIAccount();
                ia.displayAccount("Image-Super resolution using GAN", "Image-Super resolution", "Apple", "14-06-2024", "29-12-2024");



                Assembly assembly = Assembly.GetExecutingAssembly();
                Type[] type = assembly.GetTypes();
                foreach (var item in type)
                {
                    MethodInfo[] m = item.GetMethods();
                    foreach (var items in m)
                {
                    Console.WriteLine(items.Name);
                }
                }
                Console.ReadKey();
            }
        }
    }
}

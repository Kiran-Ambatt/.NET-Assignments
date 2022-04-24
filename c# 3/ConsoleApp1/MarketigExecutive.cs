using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MarketingExecutive : Employee
    {
        private double KilometerTravel;
        private double TourAllowance;
        private double TelephoneAllowance = 1000;
        private double GrossSSalary;
        private double NettSalary;

        public void CalculateSalary()
        {

            if (Salary < 5000)
            {
                this.HRA = (this.Salary * 10) / 100;
                this.TA = (this.Salary * 5) / 100;
                this.DA = (this.Salary * 15) / 100;
                this.GrossSalary = this.Salary + HRA + TA + DA;
                this.PF = (this.GrossSalary * 10) / 100;
                this.TDS = (this.GrossSalary * 18) / 100;
                this.NetSalary = this.GrossSalary - (PF + TDS);

            }
            else if (Salary > 5000 && Salary < 10000)
            {
                this.HRA = (this.Salary * 15) / 100;
                this.TA = (this.Salary * 10) / 100;
                this.DA = (this.Salary * 20) / 100;
                this.GrossSalary = this.Salary + HRA + TA + DA;
                this.PF = (this.GrossSalary * 10) / 100;
                this.TDS = (this.GrossSalary * 18) / 100;
                this.NetSalary = this.GrossSalary - (PF + TDS);
            }
            else if (Salary > 10000 && Salary < 15000)
            {
                this.HRA = (this.Salary * 20) / 100;
                this.TA = (this.Salary * 15) / 100;
                this.DA = (this.Salary * 25) / 100;
                this.GrossSalary = this.Salary + HRA + TA + DA;
                this.PF = (this.GrossSalary * 10) / 100;
                this.TDS = (this.GrossSalary * 18) / 100;
                this.NetSalary = this.GrossSalary - (PF + TDS);
            }
            else if (this.Salary > 15000 && this.Salary < 20000)
            {
                this.HRA = (this.Salary * 25) / 100;
                this.TA = (this.Salary * 20) / 100;
                this.DA = (this.Salary * 30) / 100;
                this.GrossSalary = this.Salary + HRA + TA + DA;
                this.PF = (this.GrossSalary * 10) / 100;
                this.TDS = (this.GrossSalary * 18) / 100;
                this.NetSalary = this.GrossSalary - (PF + TDS);
            }
            else if (Salary >= 20000)
            {
                this.HRA = (this.Salary * 30) / 100;
                this.TA = (this.Salary * 25) / 100;
                this.DA = (this.Salary * 35) / 100;
                this.GrossSalary = this.Salary + HRA + TA + DA;
                this.PF = (this.GrossSalary * 10) / 100;
                this.TDS = (this.GrossSalary * 18) / 100;
                this.NetSalary = this.GrossSalary - (PF + TDS);
            }


            Console.WriteLine("Enter the kilometers travelled");
            KilometerTravel = double.Parse(Console.ReadLine());
            TourAllowance = this.KilometerTravel * 5;
            this.GrossSalary = this.caalculateGrossSalary();
            NetSalary = GrossSalary - (this.PF + this.TDS);
            Console.WriteLine("the gross salary of Marketing Executive is: " + GrossSalary);
            Console.WriteLine("the net salary of Marketing Executive is: " + NetSalary);
        }
        public double caalculateGrossSalary()
        {
            GrossSSalary= (this.GrossSalary + this.TourAllowance + this.TelephoneAllowance);
            return GrossSSalary;
        }
        public static void Main()
        {
            MarketingExecutive me = new MarketingExecutive();
            me.readsalary();
            me.CalculateSalary();
        }
    }
}

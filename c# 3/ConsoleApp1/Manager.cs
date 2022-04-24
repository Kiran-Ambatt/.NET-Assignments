using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Manager : Employee
    {
        private double PetrolAllgowance = 8;
        private double FoodAllowance = 13;
        private double OtherAllowances = 3;

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

            Console.WriteLine(" Employee " + EmpName + "'s PF is: " + PF);
            Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + TDS);
            Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + this.NetSalary);
            this.GrossSalary = this.calculateGrossSalary();
            NetSalary = GrossSalary - (this.PF + this.TDS);
            Console.WriteLine("the gross salary of manager is: " + GrossSalary);
            Console.WriteLine("the net salary of manager is: " + NetSalary);
        }

        public double calculateGrossSalary()
        {
            double grossSalary = this.Salary +
                                ((this.Salary * this.PetrolAllgowance) / 100 ) + 
                               ((this.Salary * this.FoodAllowance) / 100) + 
                               ((this.Salary * this.OtherAllowances) / 100);
            return grossSalary;
        }
        public static void Main()
        {
            Manager manager = new Manager();
            manager.readsalary();
            manager.CalculateSalary();
            manager.calculateGrossSalary();
        }
    }  
}

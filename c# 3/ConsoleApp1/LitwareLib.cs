/*	Create a hierarchy of Employee, Manager, MarketingExecutive in Employee Management System. They should have the following functionality.
a)	Manager with following private members.
	Petrol Allowance: 8 % of Salary.
	Food Allowance : 13 % of Salary.
	Other Allowances : 3% of Salary.
Calculate GrossSalary by adding above allowances. Override CalculateSalary() method to calculate Net Salary. NetSalary. PF calculation should not consider above allowances.
b)	MarketingExecutive with following private members.
	Kilometer travel
	Tour Allowances : Rs 5/- per Kilometer (Automatically generated).
	Telephone Allowances : Rs.1000/-
Calculate GrossSalary by adding above allowances. Override CalculateSalary(). NetSalary,PF calculation should not consider above allowances.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        protected int EmpNo;
		protected string EmpName;
		protected double Salary;
		protected double HRA;
		protected double TA;
		protected double DA;
		protected double PF;
		protected double TDS;
		protected double NetSalary;
		protected double GrossSalary;

		public void readEmpNo()
        {
			Console.WriteLine("Enter emloyee number");
			this.EmpNo = int.Parse(Console.ReadLine());
		}

		public void readEmpName()
		{
			Console.WriteLine("Enter emloyee name");
			this.EmpName = Console.ReadLine();
		}

		public void readsalary()
		{
			Console.WriteLine("Enter emloyee salary");
			this.Salary = double.Parse(Console.ReadLine());
		}
		public void CalculateSalary()
        {
            if (Salary < 5000)
            {
				this.HRA = (this.Salary * 10)/100;
				this.TA = (this.Salary * 5) / 100;
				this.DA = (this.Salary * 15) / 100;
				this.GrossSalary = this.Salary + HRA + TA + DA;
				this.PF = (this.GrossSalary *10)/100;
				this.TDS = (this.GrossSalary * 18) / 100;
				this.NetSalary = this.GrossSalary -(PF + TDS);
				Console.WriteLine(" Employee " + EmpName +"'s PF is: " + this.PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + this.TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + this.NetSalary);


			}
			else if(Salary > 5000 && Salary < 10000)
            {
				this.HRA = (this.Salary * 15) / 100;
				this.TA = (this.Salary * 10) / 100;
				this.DA = (this.Salary * 20) / 100;
				this.GrossSalary = this.Salary + HRA + TA + DA;
				this.PF = (this.GrossSalary * 10) / 100;
				this.TDS = (this.GrossSalary * 18) / 100;
				this.NetSalary = this.GrossSalary - (PF + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s PF is: " + this.PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + this.TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + this.NetSalary);
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
				Console.WriteLine(" Employee " + EmpName + "'s PF is: " + this.PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + this.TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + this.NetSalary);
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
				Console.WriteLine(" Employee " + EmpName + "'s PF is: " + this.PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + this.TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + this.NetSalary);
			}
			else if(Salary >= 20000)
            {
				this.HRA = (this.Salary * 30) / 100;
				this.TA = (this.Salary * 25) / 100;
				this.DA = (this.Salary * 35) / 100;
				this.GrossSalary = this.Salary + HRA + TA + DA;
				this.PF = (this.GrossSalary * 10) / 100;
				this.TDS = (this.GrossSalary * 18) / 100;
				this.NetSalary = this.GrossSalary - (PF + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s PF is: " + PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + this.NetSalary);
			}

		}

		public static void Main()
		{
			Employee Empobj = new Employee();
			Empobj.readEmpNo();
			Empobj.readEmpName();
			Empobj.readsalary();
			Empobj.CalculateSalary();

		}
	}
	
}

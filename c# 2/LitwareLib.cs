/* 1)	Develop Employee Management System for Litware Organization. Write a Class Library project LitwareLib.
	Add class Employee with following private members:
	EmpNo	int
	EmpName string
	Salary double
	HRA	double
	TA	double
	DA	double
	PF	double
	TDS	double
	NetSalary double
	GrossSalary double.

Write methods for accepting EmpNo, EmpName and Salary. HRA, TA, DA, PPF, TDS, NET, GROSS should be calculated automatically. Follow the table for calculations.
Salary	HRA % of Salary	TA % of Salary	DA % of Salary
<5000	10	5	15
<10000	15	10	20
<15000	20	15	25
<20000	25	20	30
>=20000	30	25	35
GrossSalary = Salary + HRA + TA + DA.
Calculate PF, TDS and Net salary in a function named “CalculateSalary()”
PF = 10 % of GrossSalary. TDS = 18 % of GrossSalary.
NetSalary = GrossSalary – (PF + TDS).
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
        private int EmpNo;
		private string EmpName;
		private double Salary;
		private double HRA;
		private double TA;
		private double DA;
		private double PF;
		private double TDS;
		private double NetSalary;
		private double GrossSalary;

		public void readEmpNo()
        {
			Console.WriteLine("Enter emloyee number");
			EmpNo = int.Parse(Console.ReadLine());
        }

		public void readEmpName()
		{
			Console.WriteLine("Enter emloyee name");
			EmpName = Console.ReadLine();
		}

		public void readsalary()
		{
			Console.WriteLine("Enter emloyee salary");
			Salary = double.Parse(Console.ReadLine());
		}
		public void CalculateSalary()
        {
            if (Salary < 5000)
            {
				HRA = (Salary * 10)/100;
				TA = (Salary * 5) / 100;
				DA = (Salary * 15) / 100;
				GrossSalary = Salary + HRA + TA + DA;
				PF = (GrossSalary*10)/100;
				TDS = (GrossSalary * 18) / 100;
				NetSalary = GrossSalary -(PF + TDS);
				Console.WriteLine(" Employee " + EmpName +"'s PF is: " + PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + NetSalary);

			}
			else if(Salary > 5000 && Salary < 10000)
            {
				HRA = (Salary * 15) / 100;
				TA = (Salary * 10) / 100;
				DA = (Salary * 20) / 100;
				GrossSalary = Salary + HRA + TA + DA;
				PF = (GrossSalary * 10) / 100;
				TDS = (GrossSalary * 18) / 100;
				NetSalary = GrossSalary - (PF + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s PF is: " + PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + NetSalary);
			}
			else if (Salary > 10000 && Salary < 15000)
            {
				HRA = (Salary * 20) / 100;
				TA = (Salary * 15) / 100;
				DA = (Salary * 25) / 100;
				GrossSalary = Salary + HRA + TA + DA;
				PF = (GrossSalary * 10) / 100;
				TDS = (GrossSalary * 18) / 100;
				NetSalary = GrossSalary - (PF + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s PF is: " + PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + NetSalary);
			}
			else if (Salary > 15000 && Salary < 20000)
            {
				HRA = (Salary * 25) / 100;
				TA = (Salary * 20) / 100;
				DA = (Salary * 30) / 100;
				GrossSalary = Salary + HRA + TA + DA;
				PF = (GrossSalary * 10) / 100;
				TDS = (GrossSalary * 18) / 100;
				NetSalary = GrossSalary - (PF + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s PF is: " + PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + NetSalary);
			}
			else if(Salary >= 20000)
            {
				HRA = (Salary * 30) / 100;
				TA = (Salary * 25) / 100;
				DA = (Salary * 35) / 100;
				GrossSalary = Salary + HRA + TA + DA;
				PF = (GrossSalary * 10) / 100;
				TDS = (GrossSalary * 18) / 100;
				NetSalary = GrossSalary - (PF + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s PF is: " + PF);
				Console.WriteLine(" Employee " + EmpName + "'s TDS is: " + TDS);
				Console.WriteLine(" Employee " + EmpName + "'s NetSalary is: " + NetSalary);
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

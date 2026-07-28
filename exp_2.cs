using System;

namespace EmployeePayrollSystem
{
    // Interface
    interface IPayroll
    {
        double CalculateSalary();
    }

    // Base Class
    class Employee
    {
        public int EmpId;
        public string Name;

        public virtual void GetDetails()
        {
            Console.Write("Enter Employee ID: ");
            EmpId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine("\nEmployee ID : " + EmpId);
            Console.WriteLine("Employee Name : " + Name);
        }
    }

    // Full Time Employee
    class FullTimeEmployee : Employee, IPayroll
    {
        public double MonthlySalary;

        public override void GetDetails()
        {
            base.GetDetails();

            Console.Write("Enter Monthly Salary: ");
            MonthlySalary = Convert.ToDouble(Console.ReadLine());
        }

        public double CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Employee Type : Full Time");
            Console.WriteLine("Salary : " + CalculateSalary());
        }
    }

    // Part Time Employee
    class PartTimeEmployee : Employee, IPayroll
    {
        public int HoursWorked;
        public double RatePerHour;

        public override void GetDetails()
        {
            base.GetDetails();

            Console.Write("Enter Hours Worked: ");
            HoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rate Per Hour: ");
            RatePerHour = Convert.ToDouble(Console.ReadLine());
        }

        public double CalculateSalary()
        {
            return HoursWorked * RatePerHour;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Employee Type : Part Time");
            Console.WriteLine("Salary : " + CalculateSalary());
        }
    }

    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Employee Payroll System =====");
            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Enter Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            Employee emp;

            if (choice == 1)
            {
                emp = new FullTimeEmployee();
            }
            else
            {
                emp = new PartTimeEmployee();
            }

            emp.GetDetails();
            Console.WriteLine("\n------ Employee Details ------");
            emp.Display();

            Console.ReadKey();
        }
    }
}
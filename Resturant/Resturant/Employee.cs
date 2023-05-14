using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant
{
    internal class Employee : Person
    {
        private double salary=0.0;
        public string TypeJob{ get;set; }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public void extrasalary(int percient)
        {
            salary += salary * percient;
        }

        public Employee()
        {
            Salary = 0;
        }

        public Employee(string name, int id) : base(name)
        {

        }

        public Employee(string name, int id, double salary) : base(name)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            
            return base.ToString() + "".PadLeft(20) + $"Salary : {Salary}\n";
        }
        public static bool operator == (Employee emp1, Employee emp2)
        {
            return emp1.Equals(emp2);
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1.Equals(emp2));
        }
        public override bool Equals(object? obj)
        {
            if (obj is Employee)
            {
                return ((Employee)obj).SSN == SSN && ((Employee)obj).Name == Name && ((Employee)obj).Salary == Salary;
            }
            return false;
        }


    }
}

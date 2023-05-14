using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant
{
    class EmployeeList 
    {

        List<Employee> EmpList = new List<Employee>();
        public Employee this[int idx]
        {
            get
            {
                return EmpList[idx];
            }
            set
            {
                EmpList[idx] = value;
            }
        }

        public Employee? SearchEmployee(Employee emp)
        {
            for (int i = 0; i < EmpList.Count; i++)
            {
                if (EmpList[i] == emp)
                    return EmpList[i];
            }
            return null;
        }

        public Employee? SearchEmployee(string ssn)
        {
            for (int i = 0; i < EmpList.Count; i++)
            {
                if (EmpList[i].SSN == ssn)
                    return EmpList[i];
            }
            return null;
        }
        
         public void AddEmployee(Employee emp)
        {
            EmpList.Add(emp);
        }
        
        public bool RemoveEmployee(string ssn)
        {
            for (int i = 0; i < EmpList.Count; i++)
            {
                 if(EmpList[i].SSN == ssn)
                {
                    return EmpList.Remove(EmpList[i]);
                    
                } 
            }
            return false;
        }

        public void PrintAllEmployee()
        {
            for (int i = 0; i < EmpList.Count; i++)
            {
                Console.WriteLine(EmpList[i]);                
            }
        }

        // public void AddEmployee(Employee emp) => EmpList.Add(emp);

        public Cashier vaildCashir(string username, string password) // casher
        {
            for (int i = 0; i < EmpList.Count; i++)
            {
                if (EmpList[i] is Cashier)
                {
                    if (Cashier.Parse(EmpList[i]).UserName == username && Cashier.Parse(EmpList[i]).Password == password)
                        return Cashier.Parse(EmpList[i]);
                }
            }
            return null;
        }
        
    }
}

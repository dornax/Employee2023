using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employee2023
{
    internal class EmployeeRegister
    {

        public EmployeeRegister()
        {
            employeeRegister = new();
             
        }
        public void AddEmployee(string name, float salary)
        {
            employeeRegister.Add(new Employee(name, salary));

        }

        public void PrintRegister()
        {
            foreach (Employee item in employeeRegister)
            {
                Console.WriteLine(item.GetName() + " " + item.GetSalary());
            }
        }
        
        private List<Employee> employeeRegister;


    }
    
}

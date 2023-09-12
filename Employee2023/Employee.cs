using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Employee2023
{
    internal class Employee
    {
        string employeeName;

        float salary;

        public Employee(string name, float sal)
        {
            employeeName = name;
            salary = sal;  
        }

        public string GetName()
        {
            return employeeName;
        }

        public float GetSalary()
        { 
            return salary;  
        }
    
    }

    
    
   
}

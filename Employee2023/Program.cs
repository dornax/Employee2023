namespace Employee2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            EmployeeRegister employeeRegister = new();

            employeeRegister.AddEmployee("John Smith", 10000);
            employeeRegister.AddEmployee("Ann Smith", 20000);
            employeeRegister.PrintRegister();
            
            
        }
    }
}
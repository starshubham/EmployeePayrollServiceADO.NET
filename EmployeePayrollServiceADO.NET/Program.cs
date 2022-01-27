using System;

namespace EmployeePayrollServiceADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepository emprepository = new EmployeeRepository();  //Creating a object of EmployeeRepository class.

            emprepository.DataBaseConnection(); // UC1 Ensuring the database connection using the sql connection string
            //emprepository.GetAllRecord();
            Console.WriteLine();
        }
    }
}

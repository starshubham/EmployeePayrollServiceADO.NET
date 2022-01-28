using System;

namespace EmployeePayrollServiceADO.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepository repository = new EmployeeRepository();  //Creating a object of EmployeeRepository class.

            // UC1 Ensuring the database connection using the sql connection string
            //repository.DataBaseConnection(); 

            //UC2
            //AddRecordInput();                  // Add Record into Store Procedure table
            repository.GetAllEmployeeData();     // View all Records            
            Console.WriteLine();
        }

        public static void AddRecordInput()
        {
            EmployeeRepository repository = new EmployeeRepository();//Creating a object of EmployeeRepository class.
            EmployeeModel model = new EmployeeModel();// Adding Employee To Database

            model.EmployeeName = "Shubham";
            model.PhoneNumber = "8788616249";
            model.Address = "Ward No.01";
            model.Department = "HR";
            model.Gender = "M";
            model.BasicPay = 500000;
            model.Deductions = 10000;
            model.TaxablePay = 18000;
            model.Tax = 8000;
            model.NetPay = 300000;
            model.StartDate = DateTime.Now;
            model.City = "Varanasi";
            model.Country = "India";

            Console.WriteLine(repository.AddEmployee(model) ? "Record Successfully Inserted On Table" : "Failed"); //Conditional (Ternary) operator
            // repository.GetAllEmployeeData(); //call method to show table record
        }
    }
}

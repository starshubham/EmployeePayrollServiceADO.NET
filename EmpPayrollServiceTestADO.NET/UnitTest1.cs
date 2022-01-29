using EmployeePayrollServiceADO.NET;
using NUnit.Framework;

namespace EmpPayrollServiceTestADO.NET
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*TC1:- - Ability to create a payroll service database and have C# program connect to database.
                - Use the payroll_service database created in MSSQL.
                - Install System.Data.SqlClient Package.
                - Check if the database connection to payroll_service mssql DB is established.
        */
        [Test]
        public void CheckConnection()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository(); //create object EmployeeRepository class
            bool actual = employeeRepository.DataBaseConnection(); //call method
            bool expected = true; //expected true 
            Assert.AreEqual(expected, actual); // Check equal or not
        }

        /*
          TC3:- Ability to update the salary i.e. the base pay for Employee 
                Terisa to 3000000.00 and sync it with Database.
                - Update the employee payroll in the database.
                - Update the Employee Payroll Object with the Updated Salary.
                - Compare Employee Payroll Object with DB to pass the MSTest Test.
        */

        [Test]
        public void UpdateRecord() //Create UpdateRecord method to Update value on the table
        {
            string EmployeeName = "Terisa";
            double BasicPay = 3000000;
            EmployeeRepository employeeRepository = new EmployeeRepository(); //create object EmployeeRepository class
            bool actual = employeeRepository.UpdateBasicPay(EmployeeName, BasicPay); //call method and pass parameter
            bool expected = true; //expected true 
            Assert.AreEqual(expected, actual); // Check equal or not
        }

        /* TC4:- Compare Employee Payroll Object with DB to pass the Test.*/
        [Test]
        public void GivenUpdateSalaryValue_CheckIfTheDatabaseGotUpdated()
        {
            //Arrange
            string EmployeeName = "Terisa";   
            double BasicPay = 60000;
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeModel empModel = new EmployeeModel();
            //Act
            repository.UpdateBasicPay(EmployeeName, BasicPay);
            double expectedPay = repository.UpdatedSalaryFromDatabase(EmployeeName);
            //Assert
            Assert.AreEqual(BasicPay, expectedPay);  
        }

        /* TC6:- Ability to find sum, average, min, max and number of male and female employees
                 - Use Database Function SUM, AVG, MIN, MAX, COUNT to do analysis by Male and Female.
                 - Note: You will need to use GROUP BY GENDER grouping to get the result
        */
        [Test]
        public void FindGroupedByGenderRecord()
        {

            string Gender = "M";   //Arrange
            bool expected = true; //expected true 
            EmployeeRepository repository = new EmployeeRepository();
            bool actual = repository.FindGroupedByGenderRecord(Gender); //call method and pass parameter

            Assert.AreEqual(expected, actual);  //Assert
        }
    }
}
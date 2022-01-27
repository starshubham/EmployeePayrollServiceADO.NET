
Create database Payroll_Service;

exec sp_databases;   --Show all existing databases in short
select * from sys.databases;   --Show all the existing databases in details

CREATE TABLE employee_payroll
(
EmployeeID int identity(1,1) primary key,
EmployeeName varchar(50),
PhoneNumber varchar(50),
Address varchar(255),
Department varchar(50),
Gender char(1),
BasicPay float,
Deductions float,
TaxablePay float,
Tax float,
NetPay float,
StartDate Date,
City varchar(50),
Country varchar(50)
);
Select * from employee_payroll;
--drop table employee_payroll

--insert Values into the table
insert into employee_payroll(EmployeeName,PhoneNumber,Address,Department,Gender,BasicPay,Deductions,TaxablePay,Tax,NetPay,StartDate,City,Country) values
('Terisa','8788616249','Jaunpur','HR','F','300000','20000','10000','20000','180000','2021-05-20','Jaunpur','INDIA');
select * from employee_payroll;  ---Display table


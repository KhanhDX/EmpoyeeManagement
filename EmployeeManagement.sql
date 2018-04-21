drop database if exists `EmployeeManagement`;

create database `EmployeeManagement`;

use `EmployeeManagement`;

create table Employee(
OrdinalNumber int not null auto_increment,
EmployeeNumber varchar(45),
EmployeeFirstName varchar(45),
EmployeeLastName varchar(45),
Address varchar(45), 
IDCard varchar (45),
DOB date,
Sex int,
JobRankType int,
JobRankLevel int,
SalaryLevel int,
SalarySubLevel int,
primary key (OrdinalNumber)
);

truncate table Employee;
select * from Employee;
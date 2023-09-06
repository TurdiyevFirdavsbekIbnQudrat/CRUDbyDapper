global using Dapper;
global using Npgsql;
using DapperCRUD.Dtos;
using DapperCRUD.MainWorks;
using DapperCRUD.Models;



var CompanyData1 = new ForCompany();
var CompanyData2 = new companyDto()
{
    companyId = 1,
    name = "Windows",
    description = "Dasturlar yaratuvchi kompaniya",
    employeeId = 1,
};
var EmployeeData1 = new ForEmployees();
var EmployeeData2 = new employeeDto()
{
    employeId=1,
    firstname="Quvvatbek",
    lastname = "Turdiyev",
    address = "Andijon",
    email = "Quvvatbek@gmail.com",
    
};
var EmployeeData3 = new employeeDto()
{
    employeId = 1,
    firstname = "Firdavsbek",
    lastname = "Turdiyev",
    address = "Andijon",
    email = "Quvvatbek@gmail.com",

};
var staffData1= new ForStaff();
var staffData2 = new staffDto()
{
    staffId = 1,
    staffName = "Dasturchi",
};

EmployeeData1.AddData(EmployeeData2);
/*staffData1.AddData(staffData2);
CompanyData1.AddData(CompanyData2);
*/
//EmployeeData1.GetAll();
//EmployeeData1.DeleteData(1);
//EmployeeData1.UpdateData(EmployeeData3);
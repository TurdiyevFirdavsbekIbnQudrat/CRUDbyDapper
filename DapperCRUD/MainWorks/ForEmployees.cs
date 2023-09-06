using DapperCRUD.Dtos;
using DapperCRUD.Interface;
using DapperCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.MainWorks
{
    public class ForEmployees:IDbFunctions<employeeDto>
    {
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=CES;";

        public void GetAll()
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                string selects = $"select * from public.Employee";
                con.Open();
                var getData = con.Query<Employee>(selects);
                foreach (var item in getData)
                {
                    Console.WriteLine(item.firstName + item.lastName + item.address + item.email);
                }
            }
        }
        public void CreateTable()
        {

            using (var con = new NpgsqlConnection(connectionString))
            {
                string sql = "Create table Employee (employeId int,firstname varchar(30),lastname varchar(30),address varchar(30),email varchar(30)) ";

                con.Execute(sql);
            }
        }
        public void AddData(employeeDto DataWrite)
        {

            using (var con = new NpgsqlConnection(connectionString))
            {
                string sql = "insert into public.Employee Values (@employeId,@firstName,@lastName,@address,@email)"; 
                    
                con.Execute(sql, DataWrite);
            }

        }
        public void DeleteData(int Id)
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                string sql = $"Delete from public.Employee where '{Id}'=employeId";
             
                con.Execute(sql,Id);
            }
        }
     

        public void UpdateData(employeeDto DataWrite)
        {
 
            using (var con = new NpgsqlConnection(connectionString))
            {

                string sql = $"Update public.employee " +
                    $"set " +
                    $"firstname='{DataWrite.firstname}'," +
                    $"lastname = '{DataWrite.lastname}'," +
                    $"address = '{DataWrite.address}',"+
                    $"email = '{DataWrite.email}'"+
                    $"where employeId='{DataWrite.employeId}'";

              
                con.Execute(sql, DataWrite);
            }
        }
    }
}

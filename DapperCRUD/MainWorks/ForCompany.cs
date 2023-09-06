using DapperCRUD.Dtos;
using DapperCRUD.Interface;
using DapperCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.MainWorks
{
    public class ForCompany:IDbFunctions<companyDto>
    {
        public string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=CES;";
        
        public void GetAll()
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                string selects = $"select * from public.Company";
                con.Open();
                var getData= con.Query<Company>(selects);
                foreach(var item in getData) 
                {
                    Console.WriteLine(item.name + item.description);
                }
            }
        }
        public void createtable()
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                string sql = "Create table Company (companyId int,companyName varchar(30),description varchar(30),employeeId int) ";

                con.Execute(sql);
            }
        }
        public void AddData(companyDto DataWrite)
        {
            
            using (var con = new NpgsqlConnection(connectionString))
            {
                string sql = "insert into public.Company Values (@companyId,@name," +
                    "@description,@employeeId)";
                
                con.Execute(sql,DataWrite);
            }

        }
        public void DeleteData(int Id)
        {   
            using(var con = new NpgsqlConnection(connectionString))
            {
                string sql = $"Delete from public.Company where '{Id}'=companyId";
                
                con.Execute(sql);
            }
        }
        

        public void UpdateData(companyDto DataWrite)
        {
         
            using (var con = new NpgsqlConnection(connectionString))
            {

                string sql = $"Update public.Company " +
                    $"set " +
                    $"name='{DataWrite.name}'," +
                    $"description = '{DataWrite.description}'," +
                    $"where companyId='{DataWrite.companyId}'"; 
                
                
                con.Execute(sql,DataWrite);
            }
        }
    }
}

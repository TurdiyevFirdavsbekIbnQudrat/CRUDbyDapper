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
    public class ForStaff:IDbFunctions<staffDto>
    {
        public string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=CES;";

        public void GetAll()
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                string selects = $"select * from public.Staff";
                con.Open();
                var getData = con.Query<Staff>(selects);
                foreach (var item in getData)
                {
                    Console.WriteLine(item.staffName);
                }
            }
        }
        public void createStaffTable()
        {

            using (var con = new NpgsqlConnection(connectionString))
            {
                string sql = "Create table Staff (staffId int,stafName varchar(30)) ";

                con.Execute(sql);
            }
        }
        public void AddData(staffDto DataWrite)
        {

            using (var con = new NpgsqlConnection(connectionString))
            {
                string sql = "insert into public.staff Values (@staffId," +
                    "@staffName)";

                con.Execute(sql, DataWrite);
            }

        }
        public void DeleteData(int Id)
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                string sql = $"Delete from public.Staff where '{Id}'=staffId";
                
                con.Execute(sql);
            }
        }
        

        public void UpdateData(staffDto DataWrite)
        {
           
            using (var con = new NpgsqlConnection(connectionString))
            {

                string sql = $"Update public.staff " +
                    $"set " +
                    $"staffName=@staffName," +
                    $"where staffId=@staffId";
               
                con.Execute(sql, DataWrite);
            }
        }
    }
}

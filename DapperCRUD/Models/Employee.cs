using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Models
{
    public  class Employee
    {
        [Key]
        public int employeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public ICollection<Company> companies { get; set; }
        public ICollection<Staff> staffs { get; set; }
    }
}

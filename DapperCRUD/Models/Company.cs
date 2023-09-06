using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Models
{
    public class Company
    {
        [Key]
        public int companyId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        
        [ForeignKey(nameof(Employee))]
        public int employeeId { get; set; }
        public Employee employes { get; set; }
    }
}

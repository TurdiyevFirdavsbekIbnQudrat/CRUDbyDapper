using DapperCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Dtos
{
    public class companyDto
    {
        
        public int companyId { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public int employeeId { get; set; }
    }
}

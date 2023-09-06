using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Models
{
    public  class Staff
    {
        [Key]
        public int staffId { get; set; }
        public string staffName { get; set; }

        public ICollection<Employee> employees { get; set; }   
    }
}

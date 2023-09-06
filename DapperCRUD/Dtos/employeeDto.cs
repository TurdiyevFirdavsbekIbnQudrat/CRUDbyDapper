using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Dtos
{
    public class employeeDto
    {

        public int employeId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string email { get; set; }
    }
}

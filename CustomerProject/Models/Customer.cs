using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProject.Models
{
    public class Customer
    {
        public string CompanyName { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public int EmployeeCount { get; set; }
    }
}

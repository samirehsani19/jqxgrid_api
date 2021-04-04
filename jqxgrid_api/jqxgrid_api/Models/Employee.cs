using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jqxgrid_api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
    }
}
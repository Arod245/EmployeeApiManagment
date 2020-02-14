using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
    }
}
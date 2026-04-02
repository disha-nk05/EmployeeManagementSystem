using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementWeb.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Dob { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int Salary { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRManagment.Models
{
    public partial class Employee
    {
       
        public int EmpId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string EmpName { get; set; } = null!;
        [Required]
       
        public int? Age { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string? Gender { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string? Designation { get; set; }
        [Required]
        public int? Salary { get; set; }
    }
}

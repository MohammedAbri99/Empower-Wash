using System;
using System.ComponentModel.DataAnnotations;

namespace EmpowerWash.DAL.Models
{
	public class Staff:Employee
	{
        [Required]
        [StringLength(255, ErrorMessage = "Must be more than 7 char", MinimumLength = 7)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Username { get; set; }
    }
}


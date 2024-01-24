using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpowerWash.DAL.Models
{
	public class Employee
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpID { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 20)]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [MaxLength(8)]
        public long PhoneNo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        public string UserType { get; set; }

        [Required]
        [Column(TypeName = "decimal(7,3)")]
        public double Salary { get; set; }

        public ICollection<Booking> Booking { get; set; }
    }
}


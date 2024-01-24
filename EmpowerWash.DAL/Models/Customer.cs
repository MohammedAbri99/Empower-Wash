using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpowerWash.DAL.Models
{
	public class Customer
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Required]
        [MaxLength(80)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(80)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(8)]
        public long PhoneNo { get; set; }

        [Required]
        public string location { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        public ICollection<Car> Cars { get; set; }
        public ICollection<Booking> bookings { get; set; }
    }
}


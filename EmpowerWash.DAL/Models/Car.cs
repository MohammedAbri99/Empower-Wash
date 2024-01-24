using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpowerWash.DAL.Models
{
	public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int carID { get; set; }

        [Required]
        public int carNo { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string color { get; set; }

        //Relationship

        [ForeignKey("Customer")]
        public int customerID { get; set; }

        public Customer Customer { get; set; }

    }
}


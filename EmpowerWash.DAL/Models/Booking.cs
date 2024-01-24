using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerWash.DAL.Models
{
    public enum Status
    {
        Pending = 1,
        Starting,
        Done
    }
    public enum Payment_Type
    {
        Cash = 1,
        Visa
    }
    public class Booking
    {
        public int BookingID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        [Column(TypeName = "decimal(7,3)")]
        public float total_price { get; set; }
        [Required]
        public Payment_Type PaymentType { get; set; }
        [Required]
        public float discount { get; set; }
    }
}

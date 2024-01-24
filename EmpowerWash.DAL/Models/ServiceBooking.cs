using System;
namespace EmpowerWash.DAL.Models
{
	public class ServiceBooking
	{
        public int BookingID { get; set; }
        public Booking Booking { get; set; }

        public int ServicesID { get; set; }
        public Service Service { get; set; }
    }
}


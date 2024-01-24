using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class BookingRepository: GenericRepository<Booking>, IBookingRepository
    {
		public BookingRepository(ApplicationDbContext context ):base (context)
		{
		}
	}
}


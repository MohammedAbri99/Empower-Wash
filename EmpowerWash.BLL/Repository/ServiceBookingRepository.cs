using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class ServiceBookingRepository : GenericRepository<ServiceBooking>, IServiceBookingRepository
    {
		public ServiceBookingRepository(ApplicationDbContext context) : base (context)
		{
		}
	}
}


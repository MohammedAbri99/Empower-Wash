using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class ServicesRepository : GenericRepository<Service>, IServicesRepository
    {
		public ServicesRepository(ApplicationDbContext context):base (context)
		{
		}
	}
}


using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class ServiceFeedBackRepository: GenericRepository<ServiceFeadback>, IServiceFeedBackRepository
    {
		public ServiceFeedBackRepository(ApplicationDbContext context):base (context)
		{
		}
	}
}


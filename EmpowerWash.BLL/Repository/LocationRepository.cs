using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class LocationRepository: GenericRepository<Location> , ILocationRepository
    {
		public LocationRepository( ApplicationDbContext context) : base(context)
		{
		}
	}
}


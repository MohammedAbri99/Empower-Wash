using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class CarRepository: GenericRepository<Car> , ICarRepository
    {
		public CarRepository(ApplicationDbContext context): base (context)
		{
		}
	}
}


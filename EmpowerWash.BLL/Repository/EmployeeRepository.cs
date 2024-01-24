using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
		public EmployeeRepository(ApplicationDbContext context) :base (context)
		{
		}
	}
}


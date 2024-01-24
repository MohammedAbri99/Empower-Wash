using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class CustomerRepository: GenericRepository<Customer>, ICustomerRepository
    {
		public CustomerRepository(ApplicationDbContext context):base (context)
		{
		}
	}
}


using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class StaffRepository: GenericRepository<Staff>, IStaffRepository
    {
		public StaffRepository(ApplicationDbContext context) : base (context)
		{
		}
	}
}


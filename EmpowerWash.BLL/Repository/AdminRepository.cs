using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;
using EmpowerWash.DAL.Models;

namespace EmpowerWash.BLL.Repository
{
	public class AdminRepository: GenericRepository<Admin>, IAdminRepository
    {
		public AdminRepository(ApplicationDbContext context):base (context)
		{
		}
	}
}


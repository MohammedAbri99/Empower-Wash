using System;
namespace EmpowerWash.BLL.Interfaces
{
	public interface IUniteOfWprk
	{
		public IAdminRepository adminRepository { get; set; }
		public IBookingRepository bookingRepository { get; set; }
        public IEmployeeRepository employeeRepository { get; set; }
        public IStaffRepository staffRepository { get; set; }
        public ICarRepository carRepository { get; set; }
        public ICustomerRepository customerRepository { get; set; }
        public IServicesRepository servicesRepository { get; set; }
        public ILocationRepository locationRepository { get; set; }
        public IServiceFeedBackRepository feedBackRepository { get; set; }
        public IServiceFeedBackRepository serviceFeedBackRepository { get; set; }
    }
}


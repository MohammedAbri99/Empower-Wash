using System;
using EmpowerWash.BLL.Interfaces;
using EmpowerWash.DAL.Context;

namespace EmpowerWash.BLL.Repository
{
	public class UniteOfWork: IUniteOfWprk
    {
        public IAdminRepository adminRepository { get; set; }
        public IBookingRepository bookingRepository { get; set; }
        public IEmployeeRepository employeeRepository { get; set; }
        public IStaffRepository staffRepository { get; set; }
        public ICarRepository carRepository { get; set; }
        public ICustomerRepository customerRepository { get; set; }
        public IServicesRepository servicesRepository { get ; set; }
        public ILocationRepository locationRepository { get; set; }
        public IServiceFeedBackRepository feedBackRepository { get; set; }
        public IServiceFeedBackRepository serviceFeedBackRepository { get; set; }

        public UniteOfWork(ApplicationDbContext context)
        {
            adminRepository = new AdminRepository(context);
            bookingRepository = new BookingRepository(context);
            employeeRepository = new EmployeeRepository(context);
            staffRepository = new StaffRepository(context);
            customerRepository = new CustomerRepository(context);
            feedBackRepository = new ServiceFeedBackRepository(context);
            carRepository = new CarRepository(context);
            locationRepository = new LocationRepository(context);
            servicesRepository = new ServicesRepository(context);
            serviceFeedBackRepository = new ServiceFeedBackRepository(context);
        }
    }
}


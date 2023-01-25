using Admin_Data.DataContext;
using Admin_Data.Models;
using Admin_Data.Repositories;
using Admin_Data.Repositories.Interface;
using Admin_Data.Services.Interfaces;

namespace Admin_Data.Services
{
    public class AdminLoginService : IAdminLoginService
    {
        AdminLoginRepository adminLoginRepository;

        public AdminLoginService(AdminDBContext adminDBContext)
        {
            adminLoginRepository = new AdminLoginRepository(adminDBContext);
        }

        public Boolean AdminLogin(AdminLogin Details)
        {
            return adminLoginRepository.AdminLogin(Details);
        }

    }
}

using Admin_Data.Models;

namespace Admin_Data.Repositories.Interface
{
    public interface IAdminLoginRepository
    {
        public Boolean AdminLogin(AdminLogin Details);
    }
}

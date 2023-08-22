

using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository : IRespository<ApplicationUser>
    {
        void Update(ApplicationUser obj);
    }
}



using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRespository<Company>
    {
        void Update(Company obj);
    }
}

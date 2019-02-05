using Store.Commom.Infraestructure;
using Store.Domain.Entities;

namespace Store.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUsername(string username);
    }
}

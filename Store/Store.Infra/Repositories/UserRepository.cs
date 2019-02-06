using Store.Domain.Entities;
using Store.Domain.Repositories;
using Store.Infra.Contexts;
using System.Linq;

namespace Store.Infra.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(StoreContext context) : base(context) { }

        public User GetByUsername(string username)
            => _context.Users.FirstOrDefault(u => u.Username == username);
    }
}

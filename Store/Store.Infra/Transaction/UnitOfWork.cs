using Store.Domain.Repositories;
using Store.Infra.Contexts;

namespace Store.Infra.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _context;

        public UnitOfWork(StoreContext context) => _context = context;

        public void Commit() => _context.SaveChanges();
    }
}

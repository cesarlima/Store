using Store.Commom.Infraestructure;
using Store.Infra.Contexts;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Store.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly StoreContext _context;

        public Repository(StoreContext context) => _context = context;

        public void Add(TEntity entity) => _context.Add(entity);

        public bool Exists(Expression<Func<TEntity, bool>> expression)
            => _context.Set<TEntity>().Any(expression) == false;

        public void Update(TEntity entity)
           => _context.Set<TEntity>().Update(entity);
    }
}

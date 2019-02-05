using System;
using System.Linq.Expressions;

namespace Store.Commom.Infraestructure
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        bool Exists(Expression<Func<TEntity, bool>> expression);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Study4.Infrastructure.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, 
            IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        Task<TEntity> GetByIDAsync(object id);
        void Update(TEntity entity);
        Task<TEntity> DeleteAsync(object id);
        TEntity Delete(TEntity entity);
        void Insert(TEntity entity);
    }
}

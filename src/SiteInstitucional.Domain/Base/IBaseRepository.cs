using System;
using System.Collections;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SiteInstitucional.Domain
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        IUnitOfWork unitOfWork { get; }

        TEntity Add(TEntity entity);
        Task<IEnumerable> GetAll(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, object>> orderBy = null, bool asc = true, int limit = 10);
    }
}

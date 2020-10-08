using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteInstitucional.Domain;

namespace SiteInstitucional.Infra
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DatabaseContext context;

        public BaseRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public IUnitOfWork unitOfWork => this.context;

        public TEntity Add(TEntity entity)
        {
            var model = this.context.Add<TEntity>(entity);
            return model.Entity;
        }

        public async Task<IEnumerable> GetAll(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, object>> orderBy = null, bool asc = true, int limit = 10)
        {
            IQueryable<TEntity> query = this.context.Set<TEntity>().AsNoTracking();

            if (where != null)
            {
                query = query.Where(where);
            }

            if (limit > 0)
            {
                query = query.Take(limit);
            }

            return await (asc ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy)).ToListAsync();
        }
    }
}

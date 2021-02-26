
using CrudClientes.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CrudClientes.Repository
{
    public class BaseRepository<TEntity> where TEntity : BaseDomain
    {

        protected readonly ApplicationDbContext DbContext;
        internal DbSet<TEntity> dbSet;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> AllWithInactive
        {
            get
            {
                return dbSet;
            }
        }

        public IQueryable<TEntity> All
        {
            get
            {
                return dbSet.Where(x => x.Ativo);
            }
        }

        public IQueryable<TEntity> AllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = this.dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Any(predicate);
        }

        public virtual void Insert(TEntity entity)
        {
            try
            {
                ValidaModel(entity);

                entity.DataInclusao = DateTime.Now;
                entity.Id = Guid.NewGuid();

                DbContext.Add(entity);
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(TEntity entity)
        {
            try
            {
                entity.DataAlteracao = DateTime.Now;
                if (!entity.Ativo)
                    entity.DataExclusao = DateTime.Now;                
                else
                    ValidaModel(entity);

                DbContext.Update(entity);
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void AttachForUpdate(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
        }

        public virtual void DetachEntity(TEntity entityToDetach)
        {
            DbContext.Entry(entityToDetach).State = EntityState.Detached;
        }

        public virtual void ValidaModel(TEntity entityToValidate)
        {
            if (!entityToValidate.IsValid())
                throw new Exception(entityToValidate.Notification.Get());
        }

    }
}

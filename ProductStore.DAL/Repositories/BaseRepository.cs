using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.DAL.IRepositories
{
    /// <summary>
    /// Base reporsitory for all repositories and contain base functionality for child reporsitories
    /// </summary>
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        // Child repositories can use it which will be one for all repositories and disposing, so we can dispose all DBContext instance from all child repositorys at once
        protected readonly DbContext Context;

        public BaseRepository(DbContext context)
        {
            Context = context;
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }
    }
}

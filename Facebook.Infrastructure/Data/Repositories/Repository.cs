using Facebook.Domain.Base;
using Facebook.Domain.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
     
        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            if (typeof(IAuditEntity).IsAssignableFrom(typeof(T)))
            {
                ((IAuditEntity)entity).CreatedDate = DateTime.UtcNow;
            }
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            if (typeof(IDeleteEntity).IsAssignableFrom(typeof(T)))
            {
                ((IDeleteEntity)entity).IsDeleted = true;
                _context.Set<T>().Update(entity);
            }
            else
                _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> Conditions(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            if (typeof(IAuditEntity).IsAssignableFrom(typeof(T)))
            {
                ((IAuditEntity)entity).UpdatedDate = DateTime.UtcNow;
            }
            _context.Set<T>().Update(entity);
        }
    }
}

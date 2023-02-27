using InvoiceManagmentSystem.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Core.DataAccess.EntityFramework
{
    public class RepositoryBase<TEntity,TContext> : IRepositoryBase<TEntity>
    where TEntity : BaseEntity, new()
          where TContext : DbContext, new()
    {
        protected TContext _context { get; }
        public RepositoryBase(TContext context)
        {
            _context= context;
        }
    
       
        public void Add(TEntity entity)
        {
          var addedEntity= _context.Entry(entity);
            addedEntity.State= EntityState.Added;
        }

        public void Delete(TEntity entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().FirstOrDefault(filter);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>>? filter = null)
        {
            return filter == null
                                     ? _context.Set<TEntity>().ToList()
                                     : _context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
        }
        public void SaveChanges()
        {
          _context.SaveChanges();
        }

    }
}

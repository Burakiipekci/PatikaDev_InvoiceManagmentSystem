using InvoiceManagmentSystem.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Core.DataAccess.EntityFramework
{
    public interface IRepositoryBase<T> where T : BaseEntity, new()
    {
        public T? Get(Expression<Func<T, bool>> filter);
        public List<T> GetList(Expression<Func<T, bool>>? filter = null);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public void SaveChanges();
    }
}

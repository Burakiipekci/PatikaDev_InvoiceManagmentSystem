using InvoiceManagmentSystem.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Core.DataAccess.EntityFramework
{
    public interface IRepositoryBase<T> where T : class, IBaseEntity, new()
    {
        void Add(T Entity);
        void delete(T Entity);
        void DeleteById(int id);
        void update(T Entity);
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}

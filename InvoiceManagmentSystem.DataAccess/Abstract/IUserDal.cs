using InvoiceManagmentSystem.Core.DataAccess.EntityFramework;
using InvoiceManagmentSystem.Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.DataAccess.Abstract
{
    public interface IUserDal:IRepositoryBase<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}

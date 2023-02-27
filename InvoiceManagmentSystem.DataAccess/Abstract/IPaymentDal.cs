using InvoiceManagmentSystem.Core.DataAccess.EntityFramework;
using InvoiceManagmentSystem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.DataAccess.Abstract
{
    public interface IPaymentDal:IRepositoryBase<Payment>
    {
    }
}

using InvoiceManagmentSystem.Core.DataAccess.EntityFramework;
using InvoiceManagmentSystem.DataAccess.Abstract;
using InvoiceManagmentSystem.DataAccess.Context;
using InvoiceManagmentSystem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.DataAccess.Concrete.EntityFramework
{
    public class EfApartmentDal : RepositoryBase<Apartment, InvoiceManagementSystemDbContext>, IApartmentDal
    {
        private readonly InvoiceManagementSystemDbContext _context;
        public EfApartmentDal(InvoiceManagementSystemDbContext context) : base(context)
        {
            _context = context;
        }

       
    }
}

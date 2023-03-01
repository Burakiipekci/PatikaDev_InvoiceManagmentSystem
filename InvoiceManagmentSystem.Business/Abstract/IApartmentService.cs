using InvoiceManagmentSystem.Core.Entity.Concrete;
using InvoiceManagmentSystem.Core.Utilities.Results;
using InvoiceManagmentSystem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Business.Abstract
{
    public interface IApartmentService
    {
        IResult Add(Apartment apartment);
        IResult Update(Apartment apartment);
        IResult Delete(int id);
        IDataResult<List<Apartment>> GetAll();
    }
}

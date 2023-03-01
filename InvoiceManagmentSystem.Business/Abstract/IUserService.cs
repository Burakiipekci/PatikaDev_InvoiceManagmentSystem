using InvoiceManagmentSystem.Core.Entity.Concrete;
using InvoiceManagmentSystem.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Business.Abstract
{
    public interface IUserService
    {

        IDataResult<List<User>> GetAll();
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(int ıd);
      
       
    }
}

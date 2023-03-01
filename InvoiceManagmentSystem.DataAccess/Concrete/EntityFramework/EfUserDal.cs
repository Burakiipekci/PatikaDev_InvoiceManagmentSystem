using InvoiceManagmentSystem.Core.DataAccess.EntityFramework;
using InvoiceManagmentSystem.Core.Entity.Concrete;
using InvoiceManagmentSystem.DataAccess.Abstract;
using InvoiceManagmentSystem.DataAccess.Context;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : RepositoryBase<User, InvoiceManagementSystemDbContext>, IUserDal
    {

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new InvoiceManagementSystemDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}


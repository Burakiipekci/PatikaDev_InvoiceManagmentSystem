using AutoMapper;
using InvoiceManagmentSystem.Business.Abstract;
using InvoiceManagmentSystem.Business.BusinessAspect.Autofac;
using InvoiceManagmentSystem.Core.Entity.Concrete;
using InvoiceManagmentSystem.Core.Utilities.Results;
using InvoiceManagmentSystem.Core.Utilities.Security.Hashing;
using InvoiceManagmentSystem.DataAccess.Abstract;
using InvoiceManagmentSystem.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        InvoiceManagementSystemDbContext _context;

        public UserManager(IUserDal userDal, InvoiceManagementSystemDbContext context)
        {
            _userDal = userDal;
            _context = context;
        }

        [SecuredOperation("Admin")]
        public IResult Add(User user)
        {
            _userDal.Add(user); 
            return new SuccessResult("User Added");
        }

        
        public IResult Delete(int ıd)
        {

            _userDal.DeleteById(ıd);
            return new SuccessResult("User Deleted");
        }
        
        public IDataResult<List<User>> GetAll()
        {
           
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), "User Listed");
        }
       
        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
        [SecuredOperation("Admin")]
        public IResult Update(User user)
        {
         _userDal.update(user);
            return new SuccessResult("user Update");
        }
    }
}

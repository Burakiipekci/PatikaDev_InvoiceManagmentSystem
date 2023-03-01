using InvoiceManagmentSystem.Business.Abstract;
using InvoiceManagmentSystem.Core.Utilities.Results;
using InvoiceManagmentSystem.DataAccess.Abstract;
using InvoiceManagmentSystem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Business.Concrete
{
    public class ApartmentManager : IApartmentService
    {
        IApartmentDal _apartmentDal;

        public ApartmentManager(IApartmentDal apartmentDal)
        {
            _apartmentDal = apartmentDal;
        }

        public IResult Add(Apartment apartment)
        {
            _apartmentDal.Add(apartment);
            return new SuccessResult("Apartment Added");
        }

        public IResult Delete(int  id)
        {
            _apartmentDal.DeleteById(id);
            return new SuccessResult("Deleted Apartment");
            
        }

        public IDataResult<List<Apartment>> GetAll()
        {
            return new SuccessDataResult<List<Apartment>>(_apartmentDal.GetAll());
        }

        public IResult Update(Apartment apartment)
        {
            _apartmentDal.update(apartment);
            return new SuccessResult("Updated Apartment");
        }
    }
}

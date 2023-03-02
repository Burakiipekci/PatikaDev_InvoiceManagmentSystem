using InvoiceManagmentSystem.Core.Utilities.Results;
using InvoiceManagmentSystem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Business.Abstract
{
    public interface IBlockService
    {
        IResult Add(Block block);
        IResult Update(Block block);
        IResult Delete(int id);
        IDataResult<List<Block>> GetAll();
    }
}
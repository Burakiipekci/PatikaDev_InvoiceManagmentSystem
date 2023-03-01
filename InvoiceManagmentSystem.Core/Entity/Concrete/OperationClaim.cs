using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Core.Entity.Concrete
{
    public class OperationClaim:IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

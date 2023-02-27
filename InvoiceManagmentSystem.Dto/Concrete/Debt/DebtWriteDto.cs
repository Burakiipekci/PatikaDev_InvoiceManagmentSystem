using InvoiceManagmentSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Dto.Concrete.Debt
{
    public class DebtWriteDto : IWriteDto
    {
        public int CustomerID { get; set; }
        public int ApartmentID { get; set; }
        public int Cost { get; set; }
    }
}

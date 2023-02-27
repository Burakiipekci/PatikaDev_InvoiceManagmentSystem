using InvoiceManagmentSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Dto.Concrete.Payment
{
    public class PaymentWriteDto : IWriteDto
    {
        public int CustomerID { get; set; }
        public int ApartmentID { get; set; }
        public int Cost { get; set; }
        public int CardNumber { get; set; }
        public int? CardId { get; set; }
        public int Password { get; set; }
    }
}

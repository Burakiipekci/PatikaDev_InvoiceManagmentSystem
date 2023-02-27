using InvoiceManagmentSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Dto.Concrete.Message
{
    public class MessageWriteDto : IWriteDto
    {
        public int CustomerID { get; set; }
        public string WrotenMessage { get; set; }
    }
}

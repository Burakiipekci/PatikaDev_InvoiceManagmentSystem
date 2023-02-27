using InvoiceManagmentSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Dto.Concrete.Apartment
{
    public class ApartmentWriteDto : IWriteDto
    {
        public int BlockID { get; set; }
        public int StyleID { get; set; }
        public int Floor { get; set; }
    }
}

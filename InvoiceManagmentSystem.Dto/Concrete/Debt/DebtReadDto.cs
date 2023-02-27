using InvoiceManagmentSystem.Core.DTO;
using InvoiceManagmentSystem.Dto.Concrete.Apartment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Dto.Concrete.Debt
{
    public class DebtReadDto : IReadDto
    {
        public int Id { get; set; }
        public UserReadDto Customer { get; set; }
        public ApartmentReadDto Apartment { get; set; }
        public int Cost { get; set; }
    }
}

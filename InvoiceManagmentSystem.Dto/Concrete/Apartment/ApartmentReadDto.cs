using InvoiceManagmentSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Dto.Concrete.Apartment
{
    public class ApartmentReadDto : IReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BlockReadDto Block { get; set; }
        public bool IsEmpty { get; set; }
        public StyleReadDto Style { get; set; }
        public int Floor { get; set; }
        public UserReadDto Customer { get; set; }
    }
}

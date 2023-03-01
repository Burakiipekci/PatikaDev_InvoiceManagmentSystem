using InvoiceManagmentSystem.Core.Entity;
using InvoiceManagmentSystem.Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Entity.Concrete
{
    public class Apartment:IBaseEntity
    {
        [NotMapped]
        public string Name
        {
            get
            {
                return $"{Block?.Name} -> Floor:{Floor} -> Style:{Style?.Name}";
            }
        }

        public int Id { get; set; }
        public int BlockID { get; set; }
     
        public Block Block { get; set; }
        public bool IsEmpty { get; set; } = true;
        public int StyleID { get; set; }
       
        public Style Style { get; set; }
        public int Floor { get; set; }
        public int CustomerID { get; set; }
       
        public User Customer { get; set; }
       
    }
}

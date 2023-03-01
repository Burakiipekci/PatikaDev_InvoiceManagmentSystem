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
    public class Debt:IBaseEntity
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public User Customer { get; set; }
        public int ApartmentID { get; set; }
        [ForeignKey("ApartmentID")]
        public Apartment Apartment { get; set; }
        public int Cost { get; set; }
    }
}

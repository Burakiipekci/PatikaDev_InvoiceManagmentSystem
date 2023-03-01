
using InvoiceManagmentSystem.Core.Entity;
using InvoiceManagmentSystem.Core.Entity.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagmentSystem.Entity.Concrete
{
    public class Card : IBaseEntity
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public int CardPassword { get; set; }
        public int Balance { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public User Customer { get; set; }
    }
}
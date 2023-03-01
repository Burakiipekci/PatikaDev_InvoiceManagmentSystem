
using InvoiceManagmentSystem.Core.Entity;
using InvoiceManagmentSystem.Core.Entity.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagmentSystem.Entity.Concrete
{
    public class Payment : IBaseEntity
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public User Customer { get; set; }
        public int ApartmentID { get; set; }
        [ForeignKey("ApartmentID")]
        public Apartment Apartment { get; set; }
        public int CardId { get; set; }
        [ForeignKey("CardId")]
        public Card Card { get; set; }
        public int Cost { get; set; }
    }
}
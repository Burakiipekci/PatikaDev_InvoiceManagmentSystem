using InvoiceManagmentSystem.Core.Entity.Concrete;

namespace InvoiceManagmentSystem.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, Role role);
    }
}
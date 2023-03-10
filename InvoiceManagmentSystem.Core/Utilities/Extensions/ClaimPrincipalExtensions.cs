using System.Security.Claims;


namespace InvoiceManagmentSystem.Core.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }
        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
        public static string GetUserEmail(this ClaimsPrincipal claimsPrincipal)
        {
            var result = claimsPrincipal?.FindFirst(ClaimTypes.Email)?.Value ?? "<Anonymous>";
            return result;
        }
    }
}
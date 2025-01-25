using Microsoft.AspNetCore.Identity;

namespace AgriculturalSalesChain.Domain.Common
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
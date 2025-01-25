using Microsoft.AspNetCore.Identity;

namespace AgriculturalSalesChain.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
}
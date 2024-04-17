using Microsoft.AspNetCore.Identity;

namespace FastFood.Models;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
}

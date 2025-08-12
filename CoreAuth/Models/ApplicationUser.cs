using Microsoft.AspNetCore.Identity;

namespace CoreAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string BranchCode { get; set; } = "";
        public string AreaCode { get; set; } = "";
        public string FullName { get; set; } = "";
    }
}

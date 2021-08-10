using System.ComponentModel.DataAnnotations;

namespace Tier3.Models
{
    public class AuthenticateUser
    {
        [Required]
        public string username { set; get; }
        
        [Required]
        public string password { set; get; }
        
        
        
    }
}
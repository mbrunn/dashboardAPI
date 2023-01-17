using System.ComponentModel.DataAnnotations;

namespace dashboardAPI.Models 
{
    public class UserCredentials 
    {
        [Key]
        //[StringLength(24, ErrorMessage = "Username cannot exceed more than 24 characters")]
        //[RegularExpression(@"^[A-Za-z0-9]{4,24}$", ErrorMessage = "UserName cannot have special characters or space and must be at least 4 characters long!")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        
        public string Email { get; set; }
    }
}

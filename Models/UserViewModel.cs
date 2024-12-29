using System.ComponentModel.DataAnnotations;

namespace IdentityApi.Models
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)] //Hidden password.
        public string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [EmailAddress]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "UserRole is required")]
        public string UserRole { get; set; }
    }

}

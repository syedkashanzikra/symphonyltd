using System.ComponentModel.DataAnnotations;

namespace SymphonyLtd.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }

}

using System.ComponentModel.DataAnnotations;

namespace SymphonyLtd.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100)]
        public string Password { get; set; }  // Assume a password field is required for registration
        [Required]
        public string PhoneNumber { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SymphonyLtd.Models
{
    public class users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [AllowNull]
        public string RememberToken { get; set; }
        [AllowNull]
        public string Role { get; set; }

        public string PhoneNumber { get; set; }
    }
}

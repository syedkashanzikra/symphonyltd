using System.ComponentModel.DataAnnotations;

namespace SymphonyLtd.Models
{
    public class contact
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        [StringLength(250)]
        public string Message { get; set; }
    }
}

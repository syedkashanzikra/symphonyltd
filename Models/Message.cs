using System.ComponentModel.DataAnnotations;

namespace SymphonyLtd.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string Timestamp { get; set; }

    }
}


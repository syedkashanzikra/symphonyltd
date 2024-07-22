using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SymphonyLtd.Models
{
    public class students
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set;}
        [Required]
        public string StudentEmail { get; set;}
        [Required]
        public string ClassAssigned { get; set;}
        [Required]
        public int Fee { get; set;}
        [Required]
        public int Grade { get; set;}
        public int CourseId { get; set;}
        [ForeignKey("CourseId")]
        public virtual courses courses { get; set;}

    }
}

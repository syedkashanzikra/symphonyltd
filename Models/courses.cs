using System.ComponentModel.DataAnnotations;

namespace SymphonyLtd.Models
{
    public class courses
    {
        [Key]
        public int CoursesId { get; set; }
        [Required]
        public string CoursesName { get; set; }
        [Required]
        public string CoursesCovered { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter Name.")]
        public string CourseName { get; set; }

        [Required(AllowEmptyStrings = true)]
        public int Price { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Instructor { get; set; }
    }
}

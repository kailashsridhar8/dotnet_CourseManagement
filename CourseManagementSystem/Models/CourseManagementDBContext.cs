using Microsoft.EntityFrameworkCore;
namespace CourseManagementSystem.Models
{
    public class CourseManagementDBContext : DbContext
    {
        public CourseManagementDBContext(DbContextOptions<CourseManagementDBContext> options) : base(options)
        {

        }

        //Create Table here
        public DbSet<Course> Courses { get; set; }
    }

}








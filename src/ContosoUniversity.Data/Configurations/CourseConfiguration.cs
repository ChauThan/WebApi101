using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoUniversity.Entities;

namespace ContosoUniversity.Data.Configurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            HasKey(e => e.Id);
            Property(e => e.Title).IsRequired().HasMaxLength(256);
            Property(e => e.Credits).IsRequired();
            Property(e => e.DepartmentId).IsRequired();

            HasMany(c => c.Instructors)
                .WithMany(i => i.Courses)
                .Map(t => t.MapLeftKey("CourseId")
                .MapRightKey("InstructorId")
                .ToTable("CourseInstructor"));
        }
    }
}

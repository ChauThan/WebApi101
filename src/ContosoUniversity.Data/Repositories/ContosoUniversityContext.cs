using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoUniversity.Data.Configurations;
using ContosoUniversity.Entities;

namespace ContosoUniversity.Data.Repositories
{
    public class ContosoUniversityContext : DbContext
    {
        public ContosoUniversityContext() : base("ContosoUniversity")
        {
        }

        #region Entites

        public IDbSet<Course> Courses { get; set; }
        public IDbSet<Department> Departments { get; set; }
        public IDbSet<Enrollment> Enrollments { get; set; }
        public IDbSet<Instructor> Instructors { get; set; }
        public IDbSet<Student> Students { get; set; }
        public IDbSet<Person> Person { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
        } 

    }
}

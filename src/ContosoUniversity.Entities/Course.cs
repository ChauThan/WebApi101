using System.Collections.Generic;

namespace ContosoUniversity.Entities
{
    public class Course : BaseEntity<int>
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
            Instructors = new HashSet<Instructor>();
        }

        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } 
    }
}

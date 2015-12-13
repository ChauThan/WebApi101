
namespace ContosoUniversity.Entities
{
    public class Enrollment : BaseEntity<int>
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; } 
    }
}

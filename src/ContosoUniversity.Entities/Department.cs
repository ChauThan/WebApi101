using System;

namespace ContosoUniversity.Entities
{
    public class Department : BaseEntity<int>
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? InstructorId { get; set; } 
    }
}

namespace ContosoUniversity.Entities
{
    public class Course : BaseEntity<int>
    {
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; } 
    }
}

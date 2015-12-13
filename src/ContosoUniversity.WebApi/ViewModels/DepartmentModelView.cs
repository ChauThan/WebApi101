using System;

namespace ContosoUniversity.WebApi.ViewModels
{
    public class DepartmentModelView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? InstructorId { get; set; }
        public string InstructorName { get; set; }
    }
}
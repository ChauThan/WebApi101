namespace ContosoUniversity.WebApi.ViewModels
{
    public class EnrollmentViewModel
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int? Grade { get; set; }

    }
}
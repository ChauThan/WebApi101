using System;

namespace ContosoUniversity.WebApi.ViewModels
{
    public class StudentModelView
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public string FullName
        {
            get { return LastName + " " + FirstMidName; }
        }

        public DateTime EnrollmentDate { get; set; }
    }
}
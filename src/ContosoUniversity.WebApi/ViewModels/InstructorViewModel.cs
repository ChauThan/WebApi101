using System;

namespace ContosoUniversity.WebApi.ViewModels
{
    public class InstructorViewModel
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public DateTime HireDate { get; set; }
    }
}
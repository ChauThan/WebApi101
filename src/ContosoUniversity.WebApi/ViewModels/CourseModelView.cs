using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.WebApi.ViewModels
{
    public class CourseModelView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
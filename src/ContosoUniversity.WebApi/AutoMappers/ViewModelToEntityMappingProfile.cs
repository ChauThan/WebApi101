using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ContosoUniversity.Entities;
using ContosoUniversity.WebApi.ViewModels;

namespace ContosoUniversity.WebApi.AutoMappers
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        protected override void Configure()
        {
            base.Configure();

            Mapper.CreateMap<CourseModelView, Course>();
            Mapper.CreateMap<DepartmentModelView, Department>();
            Mapper.CreateMap<EnrollmentViewModel, Enrollment>();
            Mapper.CreateMap<InstructorViewModel, Instructor>();
            Mapper.CreateMap<StudentModelView, Student>();
        }
    }
}
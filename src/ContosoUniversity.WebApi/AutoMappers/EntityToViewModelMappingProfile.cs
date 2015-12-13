using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ContosoUniversity.Entities;
using ContosoUniversity.WebApi.ViewModels;

namespace ContosoUniversity.WebApi.AutoMappers
{
    public class EntityToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Course, CourseModelView>()
                .ForMember(vm => vm.DepartmentName,
                    map => map.MapFrom(s => s.Department == null ? string.Empty : s.Department.Name));

            Mapper.CreateMap<Department, DepartmentModelView>()
                .ForMember(vm => vm.InstructorName,
                    map =>
                        map.MapFrom(
                            s =>
                                s.Instructor == null
                                    ? string.Empty
                                    : s.Instructor.LastName + " " + s.Instructor.FirstMidName));

            Mapper.CreateMap<Enrollment, EnrollmentViewModel>()
                .ForMember(vm => vm.CourseName,
                    map => map.MapFrom(s => s.Course == null ? string.Empty : s.Course.Title))
                .ForMember(vm => vm.StudentName,
                    map =>
                        map.MapFrom(
                            s => s.Student == null ? string.Empty : s.Student.LastName + " " + s.Student.FirstMidName));

            Mapper.CreateMap<Instructor, InstructorViewModel>();
            Mapper.CreateMap<Student, StudentModelView>();

        }
    }
}
using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using ContosoUniversity.Entities;
using ContosoUniversity.Services.Interface;
using ContosoUniversity.WebApi.ViewModels;

namespace ContosoUniversity.WebApi.Controllers
{

    public class StudentController : ApiController
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        // GET: api/Student
        public IHttpActionResult Get()
        {
            var students = studentService.GetStudents();
            var model = Mapper.Map<IEnumerable<StudentModelView>>(students);

            return Ok(model);

        }

        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            var student = studentService.GetStudent(id);
            var model = Mapper.Map<StudentModelView>(student);

            return Ok(model);
        }

        // POST: api/Student
        public IHttpActionResult Post(StudentModelView model)
        {
            var student = Mapper.Map<Student>(model);
            studentService.CreateStudent(student);
            Mapper.Map(student, model);

            return Created(Url.Link("DefaultApi", new { controller = "Student", id = student.Id }), model);
        }

        // PUT: api/Student/5
        public IHttpActionResult Put(int id, StudentModelView model)
        {
            model.Id = id;

            var student = studentService.GetStudent(id);
            Mapper.Map(model, student);

            studentService.UpdateStudent(student);
            return Ok(model);
        }

        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            studentService.DeleteStudent(id);
            return Ok();
        }
    }
}

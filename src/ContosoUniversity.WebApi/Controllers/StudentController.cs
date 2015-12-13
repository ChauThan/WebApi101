using System.Web.Http;
using ContosoUniversity.Entities;
using ContosoUniversity.Services.Interface;

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

            return Ok(students);

        }

        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            var student = studentService.GetStudent(id);
            return Ok(student);
        }

        // POST: api/Student
        public IHttpActionResult Post(Student student)
        {
            studentService.CreateStudent(student);

            return Created(Url.Link("DefaultApi", new { controller = "Student", id = student.Id }), student);
        }

        // PUT: api/Student/5
        public IHttpActionResult Put(int id, Student student)
        {
            studentService.UpdateStudent(student);
            return Ok(student);
        }

        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            studentService.DeleteStudent(id);
            return Ok();
        }
    }
}

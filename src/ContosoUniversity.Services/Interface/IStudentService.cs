using System.Collections.Generic;
using ContosoUniversity.Entities;

namespace ContosoUniversity.Services.Interface
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        Student CreateStudent(Student student);
        Student UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}

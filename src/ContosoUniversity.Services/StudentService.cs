using System;
using System.Collections.Generic;
using System.Linq;
using ContosoUniversity.Data.Repositories;
using ContosoUniversity.Entities;
using ContosoUniversity.Services.Interface;

namespace ContosoUniversity.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<Student> studentRepository;

        public StudentService(IUnitOfWork unitOfWork, IGenericRepository<Student> studentRepository)
        {
            this.unitOfWork = unitOfWork;
            this.studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetStudents()
        {
            return studentRepository.Get();
        }

        public Student GetStudent(int id)
        {
            return studentRepository.Get(s => s.Id == id).FirstOrDefault();
        }

        public Student CreateStudent(Student student)
        {
            studentRepository.Insert(student);
            unitOfWork.SaveChanges();

            return student;
        }

        public Student UpdateStudent(Student student)
        {
            studentRepository.Update(student);
            unitOfWork.SaveChanges();

            return student;
        }

        public void DeleteStudent(int id)
        {
            studentRepository.Delete(id);
            unitOfWork.SaveChanges();
        }
    }
}

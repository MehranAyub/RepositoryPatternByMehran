using Core.Data;
using Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Services.Students
{
    internal class StudentRepository:IStudentRepository
    {
        RepositoryContext _repositoryContext;
        public StudentRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public IEnumerable<Student> GetAllStudents()
        {

            return _repositoryContext.Students.OrderBy(s => s.Name).ToList();
        }

        public Student GetStudentById(int studentId)
        {
            var student = _repositoryContext.Students.FirstOrDefault(s => s.Id == studentId);   
            return student;
        }

      public  Student GetStudentWithDetails(int studentId)
        {
            Student query=null;
            var studentEntity=_repositoryContext.Students.Where(student => student.Id.Equals(studentId)).FirstOrDefault();
            if (studentEntity != null)
            {
                var address = _repositoryContext.Addresses.Where(address => address.Id.Equals(studentEntity.AddressId)).FirstOrDefault();
                 query = new Student
                {
                    Id = studentEntity.Id,
                    Address = address,
                    RollId = studentEntity.RollId,
                    Name = studentEntity.Name,
                    Age = studentEntity.Age,
                    Class = studentEntity.Class,
                    AdmissionDate = studentEntity.AdmissionDate,
                };
            }
           

            return query;
        }

        public void CreateStudent(Student student)
        {
            _repositoryContext.Students.Add(student);

        }

        public void UpdateStudent(Student student)
        {

            _repositoryContext.Students.Update(student);
      
        }

        public void DeleteStudent(Student student)
        {

           _repositoryContext.Students.Remove(student);
        }
    }
}

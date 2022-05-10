using GraphQLApi.IService;
using GraphQLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Service
{
    public class StudentService : IStudentService
    {
        private IList<Student> _students;
        public StudentService()
        {
            _students = new List<Student>()
            {
                new Student()
                {   StudentId = 1,
                    GroupId = 1,
                    Name = "Gabriel",
                },
                new Student()
                {
                    StudentId = 2,
                    GroupId = 2,
                    Name = "Pereira",
                },
                new Student()
                {
                    StudentId = 3,
                    GroupId = 1,
                    Name = "Duarte",
                },

            };
        }
        public Student Create(CreateStudentInput inputStudent)
        {
            var student = new Student()
            {
                StudentId = _students.Max(selector => selector.StudentId) + 1,
                Name = inputStudent.Name,
                GroupId = inputStudent.GroupId
            };

            _students.Add(student);
            return student;
        }

        public Student Delete(int studentId)
        {
            var student = _students.FirstOrDefault(s => s.StudentId == studentId);

            if(student == null)
            {
                throw new Exception();
            }
            _students.Remove(student);
            return student; //estranho retornar, mas depoois penso em algo
            
        }

        public IQueryable<Student> GetAll()
        {
            return _students.AsQueryable();
        }
    }
}

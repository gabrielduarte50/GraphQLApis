using GraphQLApi.IService;
using GraphQLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.GraphQL
{
    public class Mutation
    {
        private readonly IStudentService _studentService;

        public Mutation(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public Student CreateStudent( CreateStudentInput inputStudent)
        {
            return _studentService.Create(inputStudent);
        } 
        public Student DeletStudent(int studentId)
        {
            return _studentService.Delete(studentId);
        }
    }
}

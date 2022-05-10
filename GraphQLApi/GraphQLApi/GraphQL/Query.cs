using GraphQLApi.IService;
using GraphQLApi.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.GraphQL
{
    public class Query
    {
        private readonly IGroupService _groupService;
        private readonly IStudentService _studentService;
    
        public Query(IGroupService groupService, IStudentService studentService)
        {
            _groupService = groupService;
            _studentService = studentService;
        }

        [UsePaging(SchemaType = typeof(GroupType))]
        [UseFiltering] //entender
        public IQueryable<Group> Group => _groupService.GetAll();

        [UsePaging(SchemaType = typeof(StudentType))]
        [UseFiltering]
        public IQueryable<Student> Students => _studentService.GetAll();
    }
}

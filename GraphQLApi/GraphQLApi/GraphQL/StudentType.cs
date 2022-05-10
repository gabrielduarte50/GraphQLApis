using GraphQLApi.IService;
using GraphQLApi.Models;
using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.GraphQL
{
    public class StudentType : ObjectType<Student>
    {//parece um mapper para o tipo e correlacionar as entidades
        protected override void Configure(IObjectTypeDescriptor<Student> descriptor)
        {
            descriptor.Field(x => x.Name).Type<StringType>();
            descriptor.Field(x => x.StudentId).Type<IdType>();
            descriptor.Field<GroupResolver>(x => x.GetGroup(default, default));
        }
    }

    public class GroupResolver
    {
        private readonly IGroupService _groupService;
        public GroupResolver([Service] IGroupService groupService)
        {
            _groupService = groupService;
        }

        public IEnumerable<Group> GetGroup(Student student, IResolverContext ctx)
        {
            return _groupService.GetAll().Where(x => x.GroupId == student.GroupId);
        }

    }
}

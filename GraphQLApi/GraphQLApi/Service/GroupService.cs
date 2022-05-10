using GraphQLApi.IService;
using GraphQLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Service
{
    public class GroupService : IGroupService
    {
        private IList<Group> _groups;
        public GroupService()
        {
            _groups = new List<Group>()
            {
                new Group()
                {
                    GroupId = 1,
                    Name = "Science",
                    ShortName = "SC"
                },
                new Group()
                {
                    GroupId = 2,
                    Name = "Math",
                    ShortName = "MT"
                }, 
                new Group()
                {
                    GroupId = 3,
                    Name = "History",
                    ShortName = "HT"
                },

            };
        }

        public IQueryable<Group> GetAll()
        {
            return _groups.AsQueryable(); //entender
        }
    }
}

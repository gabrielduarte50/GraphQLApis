using GraphQLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.IService
{
    public interface IGroupService
    {
        IQueryable<Group> GetAll();

    }
}

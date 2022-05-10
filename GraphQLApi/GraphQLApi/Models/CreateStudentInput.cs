using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Models
{
    public class CreateStudentInput
    {
        public string Name { get; set; }
        public int GroupId { get; set; }

    }
}

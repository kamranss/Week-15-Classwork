using DataAccess.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        public bool Create(Group entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Group entity)
        {
            throw new NotImplementedException();
        }

        public Group Get(Predicate<Group> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Group entity)
        {
            throw new NotImplementedException();
        }
    }
}

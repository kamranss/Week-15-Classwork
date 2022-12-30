using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    internal interface IGroupService
    {
        Group Create(Group group);
        Group Update(int id, Group group);
        Group Delete(int id);
        Group Get(int id);
        Group Get(string Name);
        List<Group> GetAll(string name);
        List<Group> GetAll();
    }
}

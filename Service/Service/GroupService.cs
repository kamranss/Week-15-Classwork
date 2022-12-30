using DataAccess.Repositories;
using Service.Interfaces;
using System;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    internal class GroupService : IGroupService
    {
        private readonly GroupRepository groupRepository;
        public static int Id { get; set; }
        public GroupService()
        {
            groupRepository = new GroupRepository();
        }
        public Group Create(Group group)
        {
            try
            {
                Group existgroup = groupRepository.Get(g => g.GroupName == group.GroupName);
                if (existgroup==null)
                {
                    group.Id = Id;
                    if (groupRepository.Create(group))
                    {
                        Id++;
                        return group;
                    }
                    return null;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Group Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Group Get(int id)
        {
            throw new NotImplementedException();
        }

        public Group Get(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll(string name)
        {
            try
            {
                List<Group> groups = groupRepository.GetAll(g => g.GroupName.ToLower() == name.ToLower());
                return groups;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Group Update(int id, Group group)
        {
            throw new NotImplementedException();
        }
    }
}

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
            try
            {
                AppDbContext.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Group entity)
        {
            try
            {
                AppDbContext.Groups.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Group Get(Predicate<Group> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Groups.Find(filter) : AppDbContext.Groups[0];
                #region Old verion if else
                //if (filter!=null)
                //{
                //   return AppDbContext.Groups.Find(filter);

                //}
                //return AppDbContext.Groups[0];
                #endregion
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Groups.FindAll(filter) : AppDbContext.Groups;
                #region Old version if else
                if (filter != null)
                {
                    return AppDbContext.Groups.FindAll(filter);
                }
                return AppDbContext.Groups;
                #endregion 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Group entity)
        {
            try
            {
                Group tempGroup = Get(tempgroup => tempgroup.Id == entity.Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

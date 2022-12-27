using DataAccess.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
                AppDbContext.Students.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Student entity)
        {
            try
            {
                AppDbContext.Students.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student Get(Predicate<Student> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Students.Find(filter) : AppDbContext.Students[0];
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

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Students.FindAll(filter) : AppDbContext.Students;
                #region Old version if else
                //if (filter != null)
                //{
                //    return AppDbContext.Students.FindAll(filter);
                //}
                //return AppDbContext.Students;
                #endregion 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Student entity)
        {
            try
            {
                Student tempStudent = Get(student => student.Id == entity.Id);
                if (tempStudent != null)
                {
                    tempStudent = entity;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
}

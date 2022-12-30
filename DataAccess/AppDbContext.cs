using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDbContext
    {
        public static List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }
        public AppDbContext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();
        }
    }
}

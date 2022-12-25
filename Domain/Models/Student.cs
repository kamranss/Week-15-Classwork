using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class Student : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

    }
}

﻿using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Group : IEntity
    {
        public int Id { get ; set ; }
        public string GroupName { get; set; }
        public int Maxsize { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickStart.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public School School { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}

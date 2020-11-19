using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickStart.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }
    }
}

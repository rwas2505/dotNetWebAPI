using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStart.Controllers.DTOs;
using QuickStart.Models;

namespace QuickStart.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public StudentDTO Get(int id)
        {
            return ToDTO(new Student
            {
                Id = id,
                Name = "Jim Bob",
                Class = new Class
                {
                    Id = 1,
                    Name = "Fifth Grade Class",
                    Teacher = new Teacher
                    {
                        Id = 1,
                        Name = "Mrs. Stricter",
                        School = new School
                        {
                            Id = 1,
                            Name = "School of Hard Knocks",
                            City = "Life",
                            State = "Madness"
                        }
                    }
                }
            });
        }

        private static StudentDTO ToDTO(Student student)
        {
            return new StudentDTO
            {
                Id = student.Id,
                Name = student.Name,
                ClassId = student.Class.Id,
                TeacherId = student.Class.Teacher.Id,
                SchoolId = student.Class.Teacher.School.Id
            };
        }
    }
}

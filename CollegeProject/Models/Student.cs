using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public string Email { get; set; }

        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
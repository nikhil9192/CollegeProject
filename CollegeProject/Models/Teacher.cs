using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubjectName { get; set; }
        public Subject Subject { get; set; }
    }
}
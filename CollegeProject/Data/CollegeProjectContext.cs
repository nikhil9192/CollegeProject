﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CollegeProject.Data
{
    public class CollegeProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CollegeProjectContext() : base("name=CollegeProjectContext")
        {
        }

        public System.Data.Entity.DbSet<CollegeProject.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<CollegeProject.Models.Subject> Subjects { get; set; }

        public System.Data.Entity.DbSet<CollegeProject.Models.Teacher> Teachers { get; set; }
    }
}

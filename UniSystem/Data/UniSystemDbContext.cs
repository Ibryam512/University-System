﻿using UniSystem.Data.Entities;

namespace UniSystem.Data
{
    public class UniSystemDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<News> News { get; set; }

        public UniSystemDbContext()
        {
            Students = new DbSet<Student>();
            Grades = new DbSet<Grade>();
            Users = new DbSet<User>();
            Admins = new DbSet<Admin>();
            News = new DbSet<News>();
        }
    }
}

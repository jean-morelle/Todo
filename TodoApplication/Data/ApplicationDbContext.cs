﻿using Microsoft.EntityFrameworkCore;

namespace TodoApplication.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet <TodoItem> TodoItems { get; set; }
    }

}

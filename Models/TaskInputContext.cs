using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class TaskInputContext : DbContext
    {
        //constructor
        public TaskInputContext(DbContextOptions<TaskInputContext> options) : base(options)
        {
            ///leave blank for now
        }

        public DbSet<TaskInput> responses { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Home" },
                new Category { CategoryID = 2, CategoryName = "School" },
                new Category { CategoryID = 3, CategoryName = "Work" },
                new Category { CategoryID = 4, CategoryName = "Church" }
                );

            mb.Entity<TaskInput>().HasData(

                new TaskInput
                {
                    TaskID = 1,
                    Task = "Finish Homework",
                    DueDate = new DateTime(2022, 07, 20, 09, 15, 0),
                    Quadrant = 1,
                    CategoryID = 2,
                    Completed = true
                },
                new TaskInput
                {
                    TaskID = 2,
                    Task = "Eat Dinner",
                    DueDate = new DateTime(2022, 08, 20, 05, 15, 0),
                    Quadrant = 2,
                    CategoryID = 1,
                    Completed = false
                },
                new TaskInput
                {
                    TaskID = 3,
                    Task = "Watch a Movie",
                    DueDate = new DateTime(2022, 06, 20, 09, 15, 0),
                    Quadrant = 4,
                    CategoryID = 1,
                    Completed = false
                }
                );
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class TaskInputContext : DbContext
    {
        public TaskInputContext(DbContexOptions<TaskInputContext> options) : base(options)
        {

        }
        //STILL NEED TO FIX THIS!
       
        public DbSet<TaskInput> responses { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }
                );

            mb.Entity<TaskInput>().HasData(

                new TaskInput
                {
                    TaskID = 1,
                    Task = "Finish Homework",
                    DueDate = (2022,07,20,09,15,0),
                    Quadrant = 1,
                    CategoryID = 2,
                    Completed = true                    
                },
                new TaskInput
                {
                    TaskID = 1,
                    Task = "Finish Homework",
                    DueDate = (2022, 07, 20, 09, 15, 0),
                    Quadrant = 1,
                    CategoryID = 2,
                    Completed = true
                },
                new TaskInput
                {
                    TaskID = 1,
                    Task = "Finish Homework",
                    DueDate = (2022, 07, 20, 09, 15, 0),
                    Quadrant = 1,
                    CategoryID = 2,
                    Completed = true
                }
                );
            }

        }
}

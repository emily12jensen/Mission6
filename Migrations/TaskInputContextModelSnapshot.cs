// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(TaskInputContext))]
    partial class TaskInputContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission6.Models.TaskInput", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskID");

                    b.HasIndex("CategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            TaskID = 1,
                            CategoryID = 2,
                            Completed = true,
                            DueDate = new DateTime(2022, 7, 20, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 1,
                            Task = "Finish Homework"
                        },
                        new
                        {
                            TaskID = 2,
                            CategoryID = 1,
                            Completed = false,
                            DueDate = new DateTime(2022, 8, 20, 5, 15, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 2,
                            Task = "Eat Dinner"
                        },
                        new
                        {
                            TaskID = 3,
                            CategoryID = 1,
                            Completed = false,
                            DueDate = new DateTime(2022, 6, 20, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 4,
                            Task = "Watch a Movie"
                        });
                });

            modelBuilder.Entity("Mission6.Models.TaskInput", b =>
                {
                    b.HasOne("Mission6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

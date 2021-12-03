﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TaskApi.Data.Entities;

namespace TaskApi.Data.Migrations
{
    [DbContext(typeof(TaskApiDbContext))]
    partial class TaskApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TaskApi.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "work"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "home"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "entertainment"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Miscellaneous"
                        });
                });

            modelBuilder.Entity("TaskApi.Data.Entities.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("HasCompleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            Body = "task one",
                            CategoryId = 1,
                            CreatedOn = new DateTime(2021, 12, 3, 3, 35, 56, 770, DateTimeKind.Local).AddTicks(7180),
                            HasCompleted = false,
                            LastModified = new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(300)
                        },
                        new
                        {
                            TaskId = 2,
                            Body = "task two",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(3210),
                            HasCompleted = false,
                            LastModified = new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(3240)
                        },
                        new
                        {
                            TaskId = 3,
                            Body = "task three",
                            CategoryId = 2,
                            CreatedOn = new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(3300),
                            HasCompleted = false,
                            LastModified = new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(3300)
                        });
                });

            modelBuilder.Entity("TaskApi.Data.Entities.Task", b =>
                {
                    b.HasOne("TaskApi.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

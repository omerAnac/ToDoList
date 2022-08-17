﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoList.Repository;

#nullable disable

namespace ToDoList.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220815202042_realiton-added")]
    partial class realitonadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ToDoList.Core.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Added");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DuetoDateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DueTo");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddedDate = new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5162),
                            Content = "falan filanda zımpırtı yapılacak",
                            CreatedDate = new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5177),
                            DuetoDateTime = new DateTime(2022, 8, 25, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5174),
                            IsDone = false,
                            Title = "Yapılacak 2",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AddedDate = new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5178),
                            Content = "falan filanda zımpırtı yapılacak",
                            CreatedDate = new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5180),
                            DuetoDateTime = new DateTime(2022, 9, 4, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5179),
                            IsDone = false,
                            Title = "Yapılacak 2",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("ToDoList.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5405),
                            Password = "abc.123",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("ToDoList.Core.Models.Todo", b =>
                {
                    b.HasOne("ToDoList.Core.Models.User", "User")
                        .WithMany("Todos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToDoList.Core.Models.User", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using LabTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LabTracker.Migrations
{
    [DbContext(typeof(LabTrackerContext))]
    [Migration("20181101164026_ComplexDataModel4")]
    partial class ComplexDataModel4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("LabTracker.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseNum")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("CourseID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("LabTracker.Models.CourseAssignment", b =>
                {
                    b.Property<int>("CourseID");

                    b.Property<int>("InstructorID");

                    b.HasKey("CourseID", "InstructorID");

                    b.HasIndex("InstructorID");

                    b.ToTable("CourseAssignment");
                });

            modelBuilder.Entity("LabTracker.Models.CourseEnrollment", b =>
                {
                    b.Property<int>("CourseEnrollmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseID");

                    b.Property<int>("StudentID");

                    b.HasKey("CourseEnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("CourseEnrollment");
                });

            modelBuilder.Entity("LabTracker.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstMidName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("InstructorID");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("LabTracker.Models.Lab", b =>
                {
                    b.Property<int>("LabID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Building")
                        .IsRequired();

                    b.Property<string>("Campus")
                        .IsRequired();

                    b.Property<DateTime>("LabEnd");

                    b.Property<DateTime>("LabStart");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Room");

                    b.HasKey("LabID");

                    b.ToTable("Lab");
                });

            modelBuilder.Entity("LabTracker.Models.LabAssignment", b =>
                {
                    b.Property<int>("LabID");

                    b.Property<int>("InstructorID");

                    b.HasKey("LabID", "InstructorID");

                    b.HasIndex("InstructorID");

                    b.ToTable("LabAssignment");
                });

            modelBuilder.Entity("LabTracker.Models.LabEnrollment", b =>
                {
                    b.Property<int>("LabEnrollmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseID");

                    b.Property<int>("LabID");

                    b.Property<DateTime?>("LabSignIn");

                    b.Property<DateTime?>("LabSignOut");

                    b.Property<int>("StudentID");

                    b.HasKey("LabEnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("LabID");

                    b.HasIndex("StudentID");

                    b.ToTable("LabEnrollment");
                });

            modelBuilder.Entity("LabTracker.Models.Student", b =>
                {
                    b.Property<int>("StudentID");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("LabTracker.Models.CourseAssignment", b =>
                {
                    b.HasOne("LabTracker.Models.Course", "Course")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LabTracker.Models.Instructor", "Instructor")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LabTracker.Models.CourseEnrollment", b =>
                {
                    b.HasOne("LabTracker.Models.Course", "Course")
                        .WithMany("CourseEnrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LabTracker.Models.Student", "Student")
                        .WithMany("CourseEnrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LabTracker.Models.LabAssignment", b =>
                {
                    b.HasOne("LabTracker.Models.Instructor", "Instructor")
                        .WithMany("LabAssignments")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LabTracker.Models.Lab", "Lab")
                        .WithMany("LabAssignments")
                        .HasForeignKey("LabID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LabTracker.Models.LabEnrollment", b =>
                {
                    b.HasOne("LabTracker.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LabTracker.Models.Lab", "Lab")
                        .WithMany("LabEnrollments")
                        .HasForeignKey("LabID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LabTracker.Models.Student", "Student")
                        .WithMany("LabEnrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

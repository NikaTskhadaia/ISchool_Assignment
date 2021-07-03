﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartAcademy_ISchool_Assignment.Data;

namespace SmartAcademy_ISchool_Assignment.Migrations
{
    [DbContext(typeof(SchoolManagementContext))]
    [Migration("20210703151129_change point type")]
    partial class changepointtype
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartAcademy_ISchool_Assignment.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SmartAcademy_ISchool_Assignment.Models.StudentsToSubject", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Point")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SubjectName")
                        .HasName("PK_StudentsToSubjects_1");

                    b.HasIndex("SubjectName");

                    b.ToTable("StudentsToSubjects");
                });

            modelBuilder.Entity("SmartAcademy_ISchool_Assignment.Models.Subject", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SmartAcademy_ISchool_Assignment.Models.StudentsToSubject", b =>
                {
                    b.HasOne("SmartAcademy_ISchool_Assignment.Models.Student", "Student")
                        .WithMany("StudentsToSubjects")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_StudentsToSubjects_Students")
                        .IsRequired();

                    b.HasOne("SmartAcademy_ISchool_Assignment.Models.Subject", "Subject")
                        .WithMany("StudentsToSubjects")
                        .HasForeignKey("SubjectName")
                        .HasConstraintName("FK_StudentsToSubjects_Subjects")
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SmartAcademy_ISchool_Assignment.Models.Student", b =>
                {
                    b.Navigation("StudentsToSubjects");
                });

            modelBuilder.Entity("SmartAcademy_ISchool_Assignment.Models.Subject", b =>
                {
                    b.Navigation("StudentsToSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}

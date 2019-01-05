﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentResourcesAPI.Data;

namespace StudentResourcesAPI.Migrations
{
    [DbContext(typeof(StudentResourcesContext))]
    [Migration("20190105184752_StudentResources_10_add_credential")]
    partial class StudentResources_10_add_credential
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentResourcesAPI.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("RollNumber");

                    b.Property<byte[]>("Salt");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("AccountId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.Clazz", b =>
                {
                    b.Property<int>("ClazzId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<string>("Teacher");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("ClazzId");

                    b.ToTable("Clazz");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.ClazzSubject", b =>
                {
                    b.Property<int>("ClazzId");

                    b.Property<int>("SubjectId");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Status");

                    b.HasKey("ClazzId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ClazzSubject");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.GeneralInformation", b =>
                {
                    b.Property<int>("AccountId");

                    b.Property<string>("Address");

                    b.Property<DateTime>("Dob");

                    b.Property<string>("Email");

                    b.Property<int>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("AccountId");

                    b.ToTable("GeneralInformation");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.Grade", b =>
                {
                    b.Property<int>("AccountId");

                    b.Property<int>("SubjectId");

                    b.Property<int>("AssignmentGrade");

                    b.Property<int>("AssignmentGradeStatus");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("PraticalGrade");

                    b.Property<int>("PraticalGradeStatus");

                    b.Property<int>("Status");

                    b.Property<int>("TheoricalGrade");

                    b.Property<int>("TheoricalGradeStatus");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("AccountId", "SubjectId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.RoleAccount", b =>
                {
                    b.Property<int>("RoleId");

                    b.Property<int>("AccountId");

                    b.Property<DateTime>("GrantDate");

                    b.HasKey("RoleId", "AccountId");

                    b.HasIndex("AccountId");

                    b.ToTable("RoleAccount");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.StudentClazz", b =>
                {
                    b.Property<int>("AccountId");

                    b.Property<int>("ClazzId");

                    b.Property<DateTime>("GraduateDate");

                    b.Property<DateTime>("JoinDate");

                    b.Property<int>("Status");

                    b.HasKey("AccountId", "ClazzId");

                    b.HasIndex("ClazzId");

                    b.ToTable("StudentClazz");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId");

                    b.Property<string>("Name");

                    b.HasKey("SubjectId");

                    b.HasIndex("AccountId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.ClazzSubject", b =>
                {
                    b.HasOne("StudentResourcesAPI.Models.Clazz", "Clazz")
                        .WithMany("ListClazzSubject")
                        .HasForeignKey("ClazzId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentResourcesAPI.Models.Subject", "Subject")
                        .WithMany("ListClazzSubject")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.GeneralInformation", b =>
                {
                    b.HasOne("StudentResourcesAPI.Models.Account", "Account")
                        .WithOne("GeneralInformation")
                        .HasForeignKey("StudentResourcesAPI.Models.GeneralInformation", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.Grade", b =>
                {
                    b.HasOne("StudentResourcesAPI.Models.Account")
                        .WithMany("Grades")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.RoleAccount", b =>
                {
                    b.HasOne("StudentResourcesAPI.Models.Account", "Account")
                        .WithMany("RoleAccounts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentResourcesAPI.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.StudentClazz", b =>
                {
                    b.HasOne("StudentResourcesAPI.Models.Account", "Account")
                        .WithMany("StudentClazzs")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentResourcesAPI.Models.Clazz", "Clazz")
                        .WithMany("ListStudentClazz")
                        .HasForeignKey("ClazzId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentResourcesAPI.Models.Subject", b =>
                {
                    b.HasOne("StudentResourcesAPI.Models.Account")
                        .WithMany("Subjects")
                        .HasForeignKey("AccountId");
                });
#pragma warning restore 612, 618
        }
    }
}

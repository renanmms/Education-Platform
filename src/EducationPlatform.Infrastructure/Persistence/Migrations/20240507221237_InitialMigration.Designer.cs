﻿// <auto-generated />
using System;
using EducationPlatform.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EducationPlatform.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(EducationPlatformDbContext))]
    [Migration("20240507221237_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EducationPlatform.Core.Entities.Class", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("LinkVideo")
                        .HasColumnType("text");

                    b.Property<Guid>("ModuleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Cover")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Module", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Document")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Fullname")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserClassConcluded", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ConclusionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ClassId")
                        .IsUnique();

                    b.ToTable("UserClassConcluded");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserSubscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId")
                        .IsUnique();

                    b.ToTable("UserSubscription");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Class", b =>
                {
                    b.HasOne("EducationPlatform.Core.Entities.Module", "Module")
                        .WithMany("Classes")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Course", b =>
                {
                    b.HasOne("EducationPlatform.Core.Entities.Subscription", "Subscription")
                        .WithMany("Courses")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Module", b =>
                {
                    b.HasOne("EducationPlatform.Core.Entities.Course", "Course")
                        .WithMany("Modules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserClassConcluded", b =>
                {
                    b.HasOne("EducationPlatform.Core.Entities.Class", null)
                        .WithOne("UserClassConcluded")
                        .HasForeignKey("EducationPlatform.Core.Entities.UserClassConcluded", "ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserSubscription", b =>
                {
                    b.HasOne("EducationPlatform.Core.Entities.Subscription", null)
                        .WithOne("UserSubscription")
                        .HasForeignKey("EducationPlatform.Core.Entities.UserSubscription", "SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Class", b =>
                {
                    b.Navigation("UserClassConcluded");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Course", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Module", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Subscription", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("UserSubscription");
                });
#pragma warning restore 612, 618
        }
    }
}

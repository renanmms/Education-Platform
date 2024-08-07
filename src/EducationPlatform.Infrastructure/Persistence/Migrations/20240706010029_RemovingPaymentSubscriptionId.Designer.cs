﻿// <auto-generated />
using System;
using EducationPlatform.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EducationPlatform.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(EducationPlatformDbContext))]
    [Migration("20240706010029_RemovingPaymentSubscriptionId")]
    partial class RemovingPaymentSubscriptionId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EducationPlatform.Core.Entities.Classroom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("LinkVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ModuleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Module", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.PaymentSubscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExternalPaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProcessingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserSubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserSubscriptionId")
                        .IsUnique();

                    b.ToTable("PaymentSubscriptions");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserClassConcluded", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ConclusionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("FinishedClasses");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserSubscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserSubscriptions");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Classroom", b =>
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

            modelBuilder.Entity("EducationPlatform.Core.Entities.PaymentSubscription", b =>
                {
                    b.HasOne("EducationPlatform.Core.Entities.UserSubscription", "UserSubscription")
                        .WithOne("PaymentSubscription")
                        .HasForeignKey("EducationPlatform.Core.Entities.PaymentSubscription", "UserSubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserSubscription");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserClassConcluded", b =>
                {
                    b.HasOne("EducationPlatform.Core.Entities.Classroom", "Class")
                        .WithOne("UserClassConcluded")
                        .HasForeignKey("EducationPlatform.Core.Entities.UserClassConcluded", "ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPlatform.Core.Entities.User", "User")
                        .WithOne("UserClassConcluded")
                        .HasForeignKey("EducationPlatform.Core.Entities.UserClassConcluded", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserSubscription", b =>
                {
                    b.HasOne("EducationPlatform.Core.Entities.Subscription", "Subscription")
                        .WithOne("UserSubscription")
                        .HasForeignKey("EducationPlatform.Core.Entities.UserSubscription", "SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPlatform.Core.Entities.User", "User")
                        .WithOne("UserSubscription")
                        .HasForeignKey("EducationPlatform.Core.Entities.UserSubscription", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.Classroom", b =>
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

            modelBuilder.Entity("EducationPlatform.Core.Entities.User", b =>
                {
                    b.Navigation("UserClassConcluded");

                    b.Navigation("UserSubscription");
                });

            modelBuilder.Entity("EducationPlatform.Core.Entities.UserSubscription", b =>
                {
                    b.Navigation("PaymentSubscription");
                });
#pragma warning restore 612, 618
        }
    }
}

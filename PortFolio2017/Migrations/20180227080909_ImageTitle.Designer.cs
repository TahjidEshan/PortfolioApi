﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PortFolio2017.DAL;
using PortFolio2017.Enums;
using System;

namespace PortFolio2017.Migrations
{
    [DbContext(typeof(PortfolioContext))]
    [Migration("20180227080909_ImageTitle")]
    partial class ImageTitle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortFolio2017.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("RoadNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("PortFolio2017.Models.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("PortFolio2017.Models.Education", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<bool>("CurrentlyEnrolled");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FromDate");

                    b.Property<int>("LifeEvent");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("ToDate");

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("Url");

                    b.Property<string>("UrlText");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("EducationHistory");
                });

            modelBuilder.Entity("PortFolio2017.Models.Email", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("PortFolio2017.Models.Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<long?>("EducationId");

                    b.Property<int>("LifeEvent");

                    b.Property<long?>("PublicationId");

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<long?>("WorkId");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("EducationId");

                    b.HasIndex("PublicationId");

                    b.HasIndex("UpdatedByUserId");

                    b.HasIndex("WorkId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("PortFolio2017.Models.GeneralSkill", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int>("Percentage");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("GeneralSkills");
                });

            modelBuilder.Entity("PortFolio2017.Models.Header", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Headers");
                });

            modelBuilder.Entity("PortFolio2017.Models.Image", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Title");

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("PortFolio2017.Models.Motto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Mottos");
                });

            modelBuilder.Entity("PortFolio2017.Models.Phone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("PortFolio2017.Models.Publication", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int>("LifeEvent");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("PortFolio2017.Models.PublicationAuthors", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AuthorId");

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<long>("PublicationId");

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("PublicationId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("PublicationAuthors");
                });

            modelBuilder.Entity("PortFolio2017.Models.SentMail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments")
                        .IsRequired();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<long>("EmailAddressId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("PhoneId");

                    b.Property<string>("Subject");

                    b.Property<long>("ToEmailAddressId");

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("EmailAddressId");

                    b.HasIndex("PhoneId");

                    b.HasIndex("ToEmailAddressId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("SentMails");
                });

            modelBuilder.Entity("PortFolio2017.Models.SocialService", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Icon");

                    b.Property<string>("Name");

                    b.Property<int>("SocialLinkType");

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("SocialService");
                });

            modelBuilder.Entity("PortFolio2017.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PortFolio2017.Models.Work", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<bool>("CurrentlyEmployed");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FromDate");

                    b.Property<int>("LifeEvent");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("ToDate");

                    b.Property<long>("UpdatedByUserId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("Url");

                    b.Property<string>("UrlText");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("WorkHistory");
                });

            modelBuilder.Entity("PortFolio2017.Models.Address", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Author", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Education", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Email", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Event", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.Publication", "Publication")
                        .WithMany()
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.Work", "Work")
                        .WithMany()
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.GeneralSkill", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Header", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Image", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Motto", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Phone", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Publication", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.PublicationAuthors", b =>
                {
                    b.HasOne("PortFolio2017.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.Author", "Publication")
                        .WithMany()
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.SentMail", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.Email", "EmailAddress")
                        .WithMany()
                        .HasForeignKey("EmailAddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.Email", "ToEmailAddress")
                        .WithMany()
                        .HasForeignKey("ToEmailAddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.SocialService", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortFolio2017.Models.Work", b =>
                {
                    b.HasOne("PortFolio2017.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortFolio2017.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

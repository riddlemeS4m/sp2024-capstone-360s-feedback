﻿// <auto-generated />
using System;
using Capstone_360s.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Capstone_360s.Data.Migrations.FeedbackDb
{
    [DbContext(typeof(FeedbackMySqlDbContext))]
    [Migration("20241012024954_noOfRoundsTweak")]
    partial class noOfRoundsTweak
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Feedback", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int?>("DurationSeconds")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GDFileId")
                        .HasColumnType("longtext");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RevieweeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ReviewerId")
                        .HasColumnType("char(36)");

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TimeframeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("RevieweeId");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("RoundId");

                    b.HasIndex("TimeframeId");

                    b.ToTable("feedback");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Metric", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MaxValue")
                        .HasColumnType("int");

                    b.Property<int>("MinValue")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("metrics");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.MetricResponse", b =>
                {
                    b.Property<int>("MetricId")
                        .HasColumnType("int");

                    b.Property<Guid>("FeedbackId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Response")
                        .HasColumnType("int");

                    b.HasKey("MetricId", "FeedbackId");

                    b.HasIndex("FeedbackId");

                    b.ToTable("metricresponses");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("GDFolderId")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("organizations");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GDFolderId")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("NoOfMembers")
                        .HasColumnType("int");

                    b.Property<int>("NoOfRounds")
                        .HasColumnType("int");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("POCId")
                        .HasColumnType("char(36)");

                    b.Property<int>("TimeframeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("Name");

                    b.HasIndex("POCId");

                    b.HasIndex("TimeframeId");

                    b.HasIndex("OrganizationId", "TimeframeId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.ProjectRound", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("char(36)");

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GDFolderId")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ProjectId", "RoundId");

                    b.HasIndex("RoundId");

                    b.ToTable("projectrounds");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Example")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Q")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.QuestionResponse", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<Guid>("FeedbackId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("QuestionId", "FeedbackId");

                    b.HasIndex("FeedbackId");

                    b.ToTable("questionresponses");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("rounds");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.TeamMember", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("teammembers");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Timeframe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GDFolderId")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("NoOfProjects")
                        .HasColumnType("int");

                    b.Property<int>("NoOfRounds")
                        .HasColumnType("int");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("timeframes");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsPOC")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("MicrosoftId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("OrganizationId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Feedback", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.User", "Reviewee")
                        .WithMany()
                        .HasForeignKey("RevieweeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.User", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.Timeframe", "Timeframe")
                        .WithMany()
                        .HasForeignKey("TimeframeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Reviewee");

                    b.Navigation("Reviewer");

                    b.Navigation("Round");

                    b.Navigation("Timeframe");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Metric", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.MetricResponse", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Feedback", "Feedback")
                        .WithMany()
                        .HasForeignKey("FeedbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.Metric", "Metric")
                        .WithMany()
                        .HasForeignKey("MetricId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feedback");

                    b.Navigation("Metric");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Project", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.User", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.HasOne("Capstone_360s.Models.FeedbackDb.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.User", "POC")
                        .WithMany()
                        .HasForeignKey("POCId");

                    b.HasOne("Capstone_360s.Models.FeedbackDb.Timeframe", "Timeframe")
                        .WithMany()
                        .HasForeignKey("TimeframeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");

                    b.Navigation("Organization");

                    b.Navigation("POC");

                    b.Navigation("Timeframe");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.ProjectRound", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Round");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Question", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.QuestionResponse", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Feedback", "Feedback")
                        .WithMany()
                        .HasForeignKey("FeedbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feedback");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.TeamMember", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone_360s.Models.FeedbackDb.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.Timeframe", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Capstone_360s.Models.FeedbackDb.User", b =>
                {
                    b.HasOne("Capstone_360s.Models.FeedbackDb.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });
#pragma warning restore 612, 618
        }
    }
}

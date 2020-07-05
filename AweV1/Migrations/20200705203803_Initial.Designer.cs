﻿// <auto-generated />
using System;
using AweV1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AweV1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200705203803_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AweV1.Areas.Identity.Data.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AweV1.Models.Programme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("programme");

                    b.HasData(
                        new { Id = 1, Name = "Dichtael Schwarz" }
                    );
                });

            modelBuilder.Entity("AweV1.Models.Supervisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("supervisors");

                    b.HasData(
                        new { Id = 1, Active = true, Email = "mail@mail.mail", FirstName = "Elliot", LastName = "Anderson" }
                    );
                });

            modelBuilder.Entity("AweV1.Models.Thesis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContentVal");

                    b.Property<int>("ContentWt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("DifficultyVal");

                    b.Property<int>("DifficultyWt");

                    b.Property<string>("Email");

                    b.Property<string>("Evaluation");

                    b.Property<DateTime>("Filing")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("Grade");

                    b.Property<DateTime>("LastModified")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("LayoutVal");

                    b.Property<int>("LayoutWt");

                    b.Property<int>("LiteratureVal");

                    b.Property<int>("LiteratureWt");

                    b.Property<int>("NoveltyVal");

                    b.Property<int>("NoveltyWt");

                    b.Property<int?>("ProgrammeId");

                    b.Property<DateTime>("Registration")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("RichnessVal");

                    b.Property<int>("RichnessWt");

                    b.Property<int>("Status");

                    b.Property<string>("Strengths");

                    b.Property<int>("StructureVal");

                    b.Property<int>("StructureWt");

                    b.Property<string>("StudenLastName");

                    b.Property<string>("StudentFirstName");

                    b.Property<int>("StudentID");

                    b.Property<int>("StyleVal");

                    b.Property<int>("StyleWt");

                    b.Property<string>("Summary");

                    b.Property<int?>("SupervisorId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Weaknesses");

                    b.Property<int>("type");

                    b.HasKey("Id");

                    b.HasIndex("ProgrammeId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("thesis");

                    b.HasData(
                        new { Id = 1, ContentVal = 5, ContentWt = 0, Description = "Wahnsinns Arbeit", DifficultyVal = 5, DifficultyWt = 0, Email = "joschikahn@web.de", Evaluation = "war ganz ok", Filing = new DateTime(2020, 7, 5, 22, 38, 2, 683, DateTimeKind.Local), Grade = 1m, LastModified = new DateTime(2020, 7, 5, 22, 38, 2, 680, DateTimeKind.Local), LayoutVal = 5, LayoutWt = 0, LiteratureVal = 5, LiteratureWt = 0, NoveltyVal = 5, NoveltyWt = 0, Registration = new DateTime(2020, 7, 5, 22, 38, 2, 683, DateTimeKind.Local), RichnessVal = 5, RichnessWt = 0, Status = 3, Strengths = "Alles Super", StructureVal = 5, StructureWt = 0, StudenLastName = "Hamburger", StudentFirstName = "Tschoschi", StudentID = 2278467, StyleVal = 5, StyleWt = 0, Summary = "Es geht um Omni Channels", Title = "Omni Channel Retail", Weaknesses = "Weak was?", type = 0 }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AweV1.Models.Thesis", b =>
                {
                    b.HasOne("AweV1.Models.Programme")
                        .WithMany("thesisList")
                        .HasForeignKey("ProgrammeId");

                    b.HasOne("AweV1.Models.Supervisor")
                        .WithMany("thesisList")
                        .HasForeignKey("SupervisorId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AweV1.Areas.Identity.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AweV1.Areas.Identity.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AweV1.Areas.Identity.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AweV1.Areas.Identity.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

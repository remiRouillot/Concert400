﻿// <auto-generated />
using System;
using Aumerial.EntityFrameworkCore.Metadata;
using Concert400.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Concert400.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241114165501_initialcreate")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseNTiIdentityColumns()
                .HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("ArtistConcert", b =>
                {
                    b.Property<int>("ArtistsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConcertsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArtistsId", "ConcertsId");

                    b.HasIndex("ConcertsId");

                    b.ToTable("ArtistConcert");
                });

            modelBuilder.Entity("Concert400.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("Address2")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("City")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<string>("Country")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256) ");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("SMALLINT");

                    b.Property<string>("FirstName")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("LastName")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("SMALLINT");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("CHAR(33)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("SMALLINT");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB(3M)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("SMALLINT");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256) ");

                    b.Property<string>("Zip")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Concert400.Data.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .UseNTiIdentityColumn();

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("Name")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB(3M)");

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Concert400.Data.Concert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .UseNTiIdentityColumn();

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp(6)");

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("Name")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB(3M)");

                    b.Property<int?>("PlaceId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Price")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("Concert400.Data.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .UseNTiIdentityColumn();

                    b.Property<string>("Address1")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("Address2")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("City")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("Country")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("Name")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB(3M)");

                    b.Property<string>("Zip")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("Concert400.Data.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .UseNTiIdentityColumn();

                    b.Property<bool>("Checked")
                        .HasColumnType("SMALLINT");

                    b.Property<DateTime?>("CheckedOn")
                        .HasColumnType("timestamp(6)");

                    b.Property<int?>("ConcertId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<string>("LastName")
                        .IsUnicode(true)
                        .HasColumnType("VARGRAPHIC(1024)  CCSID 1200");

                    b.Property<decimal?>("Price")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR(900) ");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256) ");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(900) ");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .UseNTiIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(900) ");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .UseNTiIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(900) ");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("VARCHAR(512) ");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(900) ");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("RoleId")
                        .HasColumnType("VARCHAR(900) ");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(900) ");

                    b.Property<string>("Value")
                        .HasColumnType("VARCHAR(512) ");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ArtistConcert", b =>
                {
                    b.HasOne("Concert400.Data.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Concert400.Data.Concert", null)
                        .WithMany()
                        .HasForeignKey("ConcertsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Concert400.Data.Concert", b =>
                {
                    b.HasOne("Concert400.Data.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceId");

                    b.Navigation("Place");
                });

            modelBuilder.Entity("Concert400.Data.Ticket", b =>
                {
                    b.HasOne("Concert400.Data.Concert", "Concert")
                        .WithMany()
                        .HasForeignKey("ConcertId");

                    b.HasOne("Concert400.Data.ApplicationUser", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId");

                    b.Navigation("Concert");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Concert400.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Concert400.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Concert400.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Concert400.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Concert400.Data.ApplicationUser", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}

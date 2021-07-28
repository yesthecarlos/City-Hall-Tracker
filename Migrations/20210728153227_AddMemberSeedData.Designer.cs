﻿// <auto-generated />
using CityHallTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CityHallTracker.Migrations
{
    [DbContext(typeof(CityHallTrackerContext))]
    [Migration("20210728153227_AddMemberSeedData")]
    partial class AddMemberSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CityHallTracker.Models.CouncilAction", b =>
                {
                    b.Property<int>("CouncilActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CouncilActionContextLink")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CouncilActionTag")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CouncilActionTitle")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CouncilActionId");

                    b.ToTable("CouncilActions");
                });

            modelBuilder.Entity("CityHallTracker.Models.CouncilActionCouncilMember", b =>
                {
                    b.Property<int>("CouncilActionCouncilMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CouncilActionId")
                        .HasColumnType("int");

                    b.Property<int>("CouncilMemberId")
                        .HasColumnType("int");

                    b.HasKey("CouncilActionCouncilMemberId");

                    b.HasIndex("CouncilActionId");

                    b.HasIndex("CouncilMemberId", "CouncilActionId")
                        .IsUnique();

                    b.ToTable("CouncilActionCouncilMember");
                });

            modelBuilder.Entity("CityHallTracker.Models.CouncilMember", b =>
                {
                    b.Property<int>("CouncilMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CouncilMemberDistrict")
                        .HasColumnType("int");

                    b.Property<string>("CouncilMemberEndDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CouncilMemberName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CouncilMemberStartDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CouncilMemberId");

                    b.ToTable("CouncilMembers");

                    b.HasData(
                        new
                        {
                            CouncilMemberId = 1,
                            CouncilMemberDistrict = 1,
                            CouncilMemberEndDate = "December 31, 2023",
                            CouncilMemberName = "Eliana Macias",
                            CouncilMemberStartDate = "January 7, 2020"
                        },
                        new
                        {
                            CouncilMemberId = 2,
                            CouncilMemberDistrict = 2,
                            CouncilMemberEndDate = "December 31, 2021",
                            CouncilMemberName = "Jason White",
                            CouncilMemberStartDate = "January 9, 2018"
                        },
                        new
                        {
                            CouncilMemberId = 3,
                            CouncilMemberDistrict = 3,
                            CouncilMemberEndDate = "December 31, 2023",
                            CouncilMemberName = "Patricia Byers",
                            CouncilMemberStartDate = "January 7, 2020"
                        },
                        new
                        {
                            CouncilMemberId = 4,
                            CouncilMemberDistrict = 4,
                            CouncilMemberEndDate = "December 31, 2021",
                            CouncilMemberName = "Kay Funk",
                            CouncilMemberStartDate = "January 9, 2018"
                        },
                        new
                        {
                            CouncilMemberId = 5,
                            CouncilMemberDistrict = 5,
                            CouncilMemberEndDate = "December 31, 2023",
                            CouncilMemberName = "Soneya Lund",
                            CouncilMemberStartDate = "January 7, 2020"
                        },
                        new
                        {
                            CouncilMemberId = 6,
                            CouncilMemberDistrict = 6,
                            CouncilMemberEndDate = "December 31, 2021",
                            CouncilMemberName = "Brad Hill",
                            CouncilMemberStartDate = "January 9, 2018"
                        },
                        new
                        {
                            CouncilMemberId = 7,
                            CouncilMemberDistrict = 7,
                            CouncilMemberEndDate = "December 31, 2023",
                            CouncilMemberName = "Holly Cousens",
                            CouncilMemberStartDate = "January 7, 2020"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("CityHallTracker.Models.CouncilActionCouncilMember", b =>
                {
                    b.HasOne("CityHallTracker.Models.CouncilAction", "CouncilAction")
                        .WithMany("JoinEntities")
                        .HasForeignKey("CouncilActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CityHallTracker.Models.CouncilMember", "CouncilMember")
                        .WithMany("JoinEntities")
                        .HasForeignKey("CouncilMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CouncilAction");

                    b.Navigation("CouncilMember");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CityHallTracker.Models.CouncilAction", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("CityHallTracker.Models.CouncilMember", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}

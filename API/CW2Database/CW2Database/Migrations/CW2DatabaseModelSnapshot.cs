﻿// <auto-generated />
using System;
using CW2Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CW2Database.Migrations
{
    [DbContext(typeof(CW2Database))]
    partial class CW2DatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CW2Database.FavouriteActivity", b =>
                {
                    b.Property<int>("UserNo")
                        .HasColumnType("int")
                        .HasColumnName("UserNo");

                    b.Property<string>("Activities")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Activities");

                    b.Property<bool>("FavouriteActivities")
                        .HasColumnType("bit")
                        .HasColumnName("FavouriteActivities");

                    b.HasKey("UserNo", "Activities");

                    b.ToTable("FavouriteActivities");
                });

            modelBuilder.Entity("CW2Database.User", b =>
                {
                    b.Property<int>("UserNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserNo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("userPassword");

                    b.Property<string>("UserStatus")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("userStatus");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Username");

                    b.HasKey("UserNo");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CW2Database.UserData", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)")
                        .HasColumnName("Email");

                    b.Property<string>("AboutMe")
                        .HasMaxLength(720)
                        .HasColumnType("nvarchar(720)")
                        .HasColumnName("AboutMe");

                    b.Property<string>("ActivityTimePreference")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("ActivityTimePreference");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2")
                        .HasColumnName("Birthday");

                    b.Property<string>("MarketingLanguage")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("MarketingLanguage");

                    b.Property<string>("MemberLocation")
                        .HasMaxLength(2147483647)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("MemberLocation");

                    b.Property<string>("Units")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Units");

                    b.Property<decimal?>("userHeight")
                        .HasColumnType("DECIMAL(5,1)")
                        .HasColumnName("userHeight");

                    b.Property<int?>("userWeight")
                        .HasColumnType("int")
                        .HasColumnName("userWeight");

                    b.HasKey("Email");

                    b.ToTable("UserData");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200423163843_SeedDataValue")]
    partial class SeedDataValue
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Value 0001"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Value 0002"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Value 0003"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Value 0004"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Value 0005"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

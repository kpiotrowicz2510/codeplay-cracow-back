﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using codeplayhackhatonback;

namespace codeplayhackhatonback.Migrations
{
    [DbContext(typeof(RachunekContext))]
    [Migration("20181027100800_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("codeplayhackhatonback.Rachunek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Rachunki");
                });
#pragma warning restore 612, 618
        }
    }
}

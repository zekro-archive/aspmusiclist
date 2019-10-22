﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using musicList2.Database;

namespace musicList2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191018142330_AppDbContext")]
    partial class AppDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("musicList2.Models.List", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Identifier");

                    b.Property<string>("KeywordHash");

                    b.Property<string>("MasterKeyHash");

                    b.HasKey("GUID");

                    b.ToTable("Lists");
                });

            modelBuilder.Entity("musicList2.Models.ListEntry<string>", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<Guid>("ListGUID");

                    b.HasKey("GUID");

                    b.ToTable("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}
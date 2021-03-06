﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Zhang.SimpleTaskApp.EntityFrameworkCore;
using Zhang.SimpleTaskApp.Tasks;

namespace Zhang.SimpleTaskApp.Migrations
{
    [DbContext(typeof(SimpleTaskAppDbContext))]
    [Migration("20171122142224_update2")]
    partial class update2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Zhang.SimpleTaskApp.Tasks.Task1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description")
                        .HasMaxLength(65536);

                    b.Property<byte>("State");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AppTasks");
                });
#pragma warning restore 612, 618
        }
    }
}

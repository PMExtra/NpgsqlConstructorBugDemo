﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NpgsqlTypes;
using WorksFine;

namespace WorksFine.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20180315060519_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290");

            modelBuilder.Entity("WorksFine.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EnumField");

                    b.Property<PostgisPoint>("Location");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });
#pragma warning restore 612, 618
        }
    }
}

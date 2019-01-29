﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MyJournal.Models.JournalModels;
using System;

namespace MyJournal.Migrations
{
    [DbContext(typeof(JournalContext))]
    partial class JournalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyJournal.Models.JournalModels.Journal", b =>
                {
                    b.Property<int>("JournalID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("JournalDateTime");

                    b.Property<string>("JournalText")
                        .IsRequired();

                    b.Property<string>("JournalUser");

                    b.HasKey("JournalID");

                    b.ToTable("Journals");
                });
#pragma warning restore 612, 618
        }
    }
}

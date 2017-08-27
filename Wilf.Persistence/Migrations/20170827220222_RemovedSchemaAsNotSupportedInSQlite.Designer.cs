﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Wilf.Persistence;

namespace Wilf.Persistence.Migrations
{
    [DbContext(typeof(WilfContext))]
    [Migration("20170827220222_RemovedSchemaAsNotSupportedInSQlite")]
    partial class RemovedSchemaAsNotSupportedInSQlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Wilf.Entities.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Descritpion");

                    b.Property<int>("EpisodeNumber");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<int>("SeasonId");

                    b.HasKey("EpisodeId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("Wilf.Entities.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Descritpion");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<int>("SeasonNumber");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Wilf.Entities.Episode", b =>
                {
                    b.HasOne("Wilf.Entities.Season", "Season")
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

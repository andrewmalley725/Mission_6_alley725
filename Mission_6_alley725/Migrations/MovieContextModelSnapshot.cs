﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission_6_alley725.Models;

namespace Mission_6_alley725.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21");

            modelBuilder.Entity("Mission_6_alley725.Models.Movies", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            category = "Sports",
                            edited = false,
                            lentTo = "",
                            notes = "My all-time favorite",
                            rating = "PG",
                            title = "Invincible",
                            year = 2006
                        },
                        new
                        {
                            movieId = 2,
                            category = "Comedy",
                            edited = false,
                            lentTo = "",
                            notes = "",
                            rating = "PG-13",
                            title = "Tommy Boy",
                            year = 1995
                        },
                        new
                        {
                            movieId = 3,
                            category = "Action",
                            edited = false,
                            lentTo = "",
                            notes = "",
                            rating = "PG-13",
                            title = "Top Gun: Maverick",
                            year = 2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

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

            modelBuilder.Entity("Mission_6_alley725.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .HasColumnType("TEXT");

                    b.HasKey("categoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            categoryId = 1,
                            category = "Action/Adventure"
                        },
                        new
                        {
                            categoryId = 2,
                            category = "Comedy"
                        },
                        new
                        {
                            categoryId = 3,
                            category = "Sports"
                        },
                        new
                        {
                            categoryId = 4,
                            category = "Drama"
                        },
                        new
                        {
                            categoryId = 5,
                            category = "Family"
                        },
                        new
                        {
                            categoryId = 6,
                            category = "Horror/Suspense"
                        },
                        new
                        {
                            categoryId = 7,
                            category = "Miscellaneous"
                        },
                        new
                        {
                            categoryId = 8,
                            category = "Television"
                        },
                        new
                        {
                            categoryId = 9,
                            category = "VHS"
                        });
                });

            modelBuilder.Entity("Mission_6_alley725.Models.Movies", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<int>("ratingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieId");

                    b.HasIndex("categoryId");

                    b.HasIndex("ratingId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            categoryId = 3,
                            edited = false,
                            lentTo = "",
                            notes = "My all-time favorite",
                            ratingId = 2,
                            title = "Invincible",
                            year = 2006
                        },
                        new
                        {
                            movieId = 2,
                            categoryId = 2,
                            edited = false,
                            lentTo = "",
                            notes = "",
                            ratingId = 3,
                            title = "Tommy Boy",
                            year = 1995
                        },
                        new
                        {
                            movieId = 3,
                            categoryId = 1,
                            edited = false,
                            lentTo = "",
                            notes = "",
                            ratingId = 3,
                            title = "Top Gun: Maverick",
                            year = 2022
                        });
                });

            modelBuilder.Entity("Mission_6_alley725.Models.Ratings", b =>
                {
                    b.Property<int>("ratingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("rating")
                        .HasColumnType("TEXT");

                    b.HasKey("ratingId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            ratingId = 1,
                            rating = "G"
                        },
                        new
                        {
                            ratingId = 2,
                            rating = "PG"
                        },
                        new
                        {
                            ratingId = 3,
                            rating = "PG-13"
                        },
                        new
                        {
                            ratingId = 4,
                            rating = "R"
                        });
                });

            modelBuilder.Entity("Mission_6_alley725.Models.Movies", b =>
                {
                    b.HasOne("Mission_6_alley725.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mission_6_alley725.Models.Ratings", "rating")
                        .WithMany()
                        .HasForeignKey("ratingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

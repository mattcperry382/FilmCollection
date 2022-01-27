﻿// <auto-generated />
using JoelHiltonFilmCollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JoelHiltonFilmCollection.Migrations
{
    [DbContext(typeof(FilmCollectionContext))]
    [Migration("20220127071435_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("JoelHiltonFilmCollection.Models.FilmCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("collection");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Action/Adventure",
                            Director = "John McTiernan",
                            Edited = true,
                            Rating = "R",
                            Title = "Predator",
                            Year = "1987"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Action/Adventure",
                            Director = "Joss Whedon",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Avengers, The",
                            Year = "2012"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Action/Adventure",
                            Director = "Peter Jackson",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Lord of the Rings: The Return of the King, The",
                            Year = "2003"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

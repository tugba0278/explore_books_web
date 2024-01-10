﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using explore_books.Pages.PROJECT;

#nullable disable

namespace explore_books.Migrations
{
    [DbContext(typeof(db))]
    [Migration("20240110112931_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("explore_books.Pages.PROJECT.Author", b =>
                {
                    b.Property<int>("authorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("authorImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("authorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("authorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("explore_books.Pages.PROJECT.Book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("bookImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("bookName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("bookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("explore_books.Pages.PROJECT.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegisterEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegisterPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}

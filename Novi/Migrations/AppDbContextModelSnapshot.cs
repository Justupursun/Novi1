﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Novi.Models;

namespace Novi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Novi.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hireable")
                        .HasColumnType("bit");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArticleOfTheMonth")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ArticleId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            CategoryId = 1,
                            Description = "Our famous apple pies!",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            IsArticleOfTheMonth = true,
                            Name = "Apple Article",
                            Price = 12.95m
                        },
                        new
                        {
                            ArticleId = 2,
                            CategoryId = 2,
                            Description = "You'll love it!",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            IsArticleOfTheMonth = false,
                            Name = "Blueberry Cheese Cake",
                            Price = 18.95m
                        },
                        new
                        {
                            ArticleId = 3,
                            CategoryId = 2,
                            Description = "Plain cheese cake. Plain pleasure.",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                            IsArticleOfTheMonth = false,
                            Name = "Cheese Cake",
                            Price = 18.95m
                        },
                        new
                        {
                            ArticleId = 4,
                            CategoryId = 1,
                            Description = "A summer classic!",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                            IsArticleOfTheMonth = false,
                            Name = "Cherry Article",
                            Price = 15.95m
                        },
                        new
                        {
                            ArticleId = 5,
                            CategoryId = 3,
                            Description = "Happy holidays with this pie!",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                            IsArticleOfTheMonth = false,
                            Name = "Christmas Apple Article",
                            Price = 13.95m
                        },
                        new
                        {
                            ArticleId = 6,
                            CategoryId = 3,
                            Description = "A Christmas favorite",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                            IsArticleOfTheMonth = false,
                            Name = "Cranberry Article",
                            Price = 17.95m
                        },
                        new
                        {
                            ArticleId = 7,
                            CategoryId = 1,
                            Description = "Sweet as peach",
                            Hireable = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                            IsArticleOfTheMonth = false,
                            Name = "Peach Article",
                            Price = 15.95m
                        },
                        new
                        {
                            ArticleId = 8,
                            CategoryId = 3,
                            Description = "Our Halloween favorite",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                            IsArticleOfTheMonth = true,
                            Name = "Pumpkin Article",
                            Price = 12.95m
                        },
                        new
                        {
                            ArticleId = 9,
                            CategoryId = 1,
                            Description = "My God, so sweet!",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                            IsArticleOfTheMonth = true,
                            Name = "Rhubarb Article",
                            Price = 15.95m
                        },
                        new
                        {
                            ArticleId = 10,
                            CategoryId = 1,
                            Description = "Our delicious strawberry pie!",
                            Hireable = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                            IsArticleOfTheMonth = false,
                            Name = "Strawberry Article",
                            Price = 15.95m
                        },
                        new
                        {
                            ArticleId = 11,
                            CategoryId = 2,
                            Description = "You'll love it!",
                            Hireable = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                            IsArticleOfTheMonth = false,
                            Name = "Strawberry Cheese Cake",
                            Price = 18.95m
                        });
                });

            modelBuilder.Entity("Novi.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Abstract pie"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Surrealistic pie"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Other pie"
                        });
                });

            modelBuilder.Entity("Novi.Models.Article", b =>
                {
                    b.HasOne("Novi.Models.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

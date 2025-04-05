﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SimplyBooks.Data;

#nullable disable

namespace SimplyBooks_BE.Migrations
{
    [DbContext(typeof(SimplyBooksDbContext))]
    [Migration("20250403174110_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("integer");

                    b.Property<int>("BooksId")
                        .HasColumnType("integer");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("SimplyBooks.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Favorite")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "lena.marquez@example.com",
                            Favorite = true,
                            FirstName = "Lena",
                            Image = "https://example.com/images/lena.jpg",
                            LastName = "Marquez",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "jasper.thorne@example.com",
                            Favorite = false,
                            FirstName = "Jasper",
                            Image = "https://example.com/images/jasper.jpg",
                            LastName = "Thorne",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "mira.ellwood@example.com",
                            Favorite = true,
                            FirstName = "Mira",
                            Image = "https://example.com/images/mira.jpg",
                            LastName = "Ellwood",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Email = "ronan.vale@example.com",
                            Favorite = false,
                            FirstName = "Ronan",
                            Image = "https://example.com/images/ronan.jpg",
                            LastName = "Vale",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Email = "tessa.hart@example.com",
                            Favorite = true,
                            FirstName = "Tessa",
                            Image = "https://example.com/images/tessa.jpg",
                            LastName = "Hart",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("SimplyBooks.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<bool>("Sale")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "A journey through forgotten realms and memory.",
                            Image = "https://example.com/images/starlit.jpg",
                            Price = 19.99m,
                            Sale = true,
                            Title = "The Starlit Archive",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "Hope and loss in a fractured future.",
                            Image = "https://example.com/images/echoes.jpg",
                            Price = 15.49m,
                            Sale = false,
                            Title = "Echoes of the Sun",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Description = "A detective uncovers more than just crime.",
                            Image = "https://example.com/images/fog.jpg",
                            Price = 12.00m,
                            Sale = false,
                            Title = "Whispers in Fog",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Description = "A thriller told through the eyes of a blind photographer.",
                            Image = "https://example.com/images/lens.jpg",
                            Price = 18.25m,
                            Sale = true,
                            Title = "The Ivory Lens",
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            Description = "A poetic journey through time.",
                            Image = "https://example.com/images/fragments.jpg",
                            Price = 9.99m,
                            Sale = true,
                            Title = "Fragments of Tomorrow",
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 4,
                            Description = "Dark fantasy meets introspective drama.",
                            Image = "https://example.com/images/reverie.jpg",
                            Price = 22.95m,
                            Sale = false,
                            Title = "Midnight Reverie",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 4,
                            Description = "A city reborn from the flames of betrayal.",
                            Image = "https://example.com/images/ashes.jpg",
                            Price = 17.50m,
                            Sale = true,
                            Title = "Ashes & Amber",
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 5,
                            Description = "A librarian incites a revolution with banned books.",
                            Image = "https://example.com/images/rebellion.jpg",
                            Price = 13.75m,
                            Sale = false,
                            Title = "The Quiet Rebellion",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("SimplyBooks.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "skylinevibe42@gmail.com",
                            UserName = "skylineVibe42"
                        },
                        new
                        {
                            Id = 2,
                            Email = "crimson.otter9@yahoo.com",
                            UserName = "crimsonOtter9"
                        },
                        new
                        {
                            Id = 3,
                            Email = "frostnova_88@outlook.com",
                            UserName = "frostNova_88"
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("SimplyBooks.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimplyBooks.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimplyBooks.Models.Author", b =>
                {
                    b.HasOne("SimplyBooks.Models.User", null)
                        .WithMany("Authors")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimplyBooks.Models.Book", b =>
                {
                    b.HasOne("SimplyBooks.Models.User", null)
                        .WithMany("Books")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimplyBooks.Models.User", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

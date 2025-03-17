﻿// <auto-generated />
using System;
using CinemaApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaApp.Data.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20250317164024_SeedCinemas")]
    partial class SeedCinemas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CinemaApp.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("CinemaApp.Data.Models.ApplicationUserMovie", b =>
                {
                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key to the user)");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key to the movie");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasComment("Shows if movie from user watchlist is deleted");

                    b.HasKey("ApplicationUserId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ApplicationUserMovies", t =>
                        {
                            t.HasComment("Movie watchlist for system user");
                        });
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Cinema", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Cinema identifier");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasComment("Shows if a cinema is deleted");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasComment("Cinema location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasComment("Cinema name");

                    b.HasKey("Id");

                    b.ToTable("Cinemas", t =>
                        {
                            t.HasComment("Cinemas in the system");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("78ff97e2-cb87-40a5-9a9c-cb5b83cd0db6"),
                            IsDeleted = false,
                            Location = "Sofia",
                            Name = "Cinema city"
                        },
                        new
                        {
                            Id = new Guid("ef42c3dd-5406-4a1c-84c2-c681eff017fc"),
                            IsDeleted = false,
                            Location = "Plovdiv",
                            Name = "Cinema city"
                        },
                        new
                        {
                            Id = new Guid("fafc9e00-03a1-4fbb-a805-455688c051c0"),
                            IsDeleted = false,
                            Location = "Varna",
                            Name = "Cinemax"
                        });
                });

            modelBuilder.Entity("CinemaApp.Data.Models.CinemaMovie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableTickets")
                        .HasColumnType("int")
                        .HasComment("Ammount of available tickets for this movie in this cinema");

                    b.Property<Guid>("CinemaId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key to the cinema");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasComment("Shows if movie in a cinema is deleted");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key to the movie");

                    b.Property<string>("Showtimes")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasDefaultValue("00000")
                        .HasComment("Shows the movie schedule in the cinema");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("CinemaId", "MovieId")
                        .IsUnique();

                    b.ToTable("CinemaMovies", t =>
                        {
                            t.HasComment("Movies in a cinema with available tickets and schedule");
                        });
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Movie identifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasComment("Movie description");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Movie director");

                    b.Property<int>("Duration")
                        .HasColumnType("int")
                        .HasComment("Movie duration");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Movie genre");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)")
                        .HasComment("Movie image URL from the image store");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasComment("Shows if movie is deleted");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2")
                        .HasComment("Movie release date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Movie title");

                    b.HasKey("Id");

                    b.ToTable("Movies", t =>
                        {
                            t.HasComment("Movies in the system");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae50a5ab-9642-466f-b528-3cc61071bb4c"),
                            Description = "Harry Potter and the Goblet of Fire is a 2005 fantasy film directed by Mike Newell from a screenplay by Steve Kloves. It is based on the 2000 novel Harry Potter and the Goblet of Fire by J. K. Rowling.",
                            Director = "Mike Newel",
                            Duration = 157,
                            Genre = "Fantasy",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI1NDMyMjExOF5BMl5BanBnXkFtZTcwOTc4MjQzMQ@@._V1_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Harry Potter and the Goblet of Fire"
                        },
                        new
                        {
                            Id = new Guid("777634e2-3bb6-4748-8e91-7a10b70c78ac"),
                            Description = "The Lord of the Rings: The Fellowship of the Ring is a 2001 epic high fantasy adventure film directed by Peter Jackson from a screenplay by Fran Walsh, Philippa Boyens, and Jackson, based on 1954's The Fellowship of the Ring, the first volume of the novel The Lord of the Rings by J. R. R. Tolkien.",
                            Director = "Peter Jackson",
                            Duration = 178,
                            Genre = "Fantasy",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzIxMDQ2YTctNDY4MC00ZTRhLTk4ODQtMTVlOWY4NTdiYmMwXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Lord of the Rings"
                        },
                        new
                        {
                            Id = new Guid("68fb84b9-ef2a-402f-b4fc-595006f5c275"),
                            Description = "A thief who enters the dreams of others to steal secrets is given the inverse task: planting an idea into someone's mind.",
                            Director = "Christopher Nolan",
                            Duration = 148,
                            Genre = "Sci-Fi",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            Id = new Guid("02b52bb0-1c2b-49a4-ba66-6d33f81d38d1"),
                            Description = "Batman faces the Joker, who seeks to create chaos in Gotham through psychological warfare.",
                            Director = "Christopher Nolan",
                            Duration = 152,
                            Genre = "Action",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UX1000_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("16376cc6-b3e0-4bf7-a0e4-9cbd1490522c"),
                            Description = "A group of explorers travel through a wormhole in space in search of a new habitable planet.",
                            Director = "Christopher Nolan",
                            Duration = 169,
                            Genre = "Sci-Fi",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzdjMDAxZGItMjI2My00ODA1LTlkNzItOWFjMDU5ZDJlYWY3XkEyXkFqcGc@._V1_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Interstellar"
                        },
                        new
                        {
                            Id = new Guid("811a1a9e-61a8-4f6f-acb0-55a252c2b713"),
                            Description = "A paraplegic Marine is sent to the moon Pandora on a mission but becomes torn between following orders and protecting an alien civilization.",
                            Director = "James Cameron",
                            Duration = 162,
                            Genre = "Sci-Fi",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDEzMmQwZjctZWU2My00MWNlLWE0NjItMDJlYTRlNGJiZjcyXkEyXkFqcGc@._V1_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Avatar"
                        },
                        new
                        {
                            Id = new Guid("ab2c3213-48a7-41ea-9393-45c60ef813e6"),
                            Description = "A love story unfolds on the doomed voyage of the Titanic.",
                            Director = "James Cameron",
                            Duration = 195,
                            Genre = "Romance",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzYyN2FiZmUtYWYzMy00MzViLWJkZTMtOGY1ZjgzNWMwN2YxXkEyXkFqcGc@._V1_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Titanic"
                        },
                        new
                        {
                            Id = new Guid("844d9abd-104d-41ab-b14a-ce059779ad91"),
                            Description = "A computer hacker learns about the true nature of his reality and his role in the war against its controllers.",
                            Director = "Lana Wachowski, Lilly Wachowski",
                            Duration = 136,
                            Genre = "Sci-Fi",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BN2NmN2VhMTQtMDNiOS00NDlhLTliMjgtODE2ZTY0ODQyNDRhXkEyXkFqcGc@._V1_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = new Guid("54082f99-023b-4d68-89ac-44c00a0958d0"),
                            Description = "The story of a man with a kind heart and an incredible life journey.",
                            Director = "Robert Zemeckis",
                            Duration = 142,
                            Genre = "Drama",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Forrest Gump"
                        },
                        new
                        {
                            Id = new Guid("bf9ff8b3-3209-4b18-9f4b-5172c45b73f9"),
                            Description = "A betrayed Roman general seeks revenge against the corrupt emperor who murdered his family and sent him into slavery.",
                            Director = "Ridley Scott",
                            Duration = 155,
                            Genre = "Action",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fb/Gladiator_%282000_film_poster%29.png",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Gladiator"
                        },
                        new
                        {
                            Id = new Guid("e00208b1-cb12-4bd4-8ac1-36ab62f7b4c9"),
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Director = "Frank Darabont",
                            Duration = 142,
                            Genre = "Drama",
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDAyY2FhYjctNDc5OS00MDNlLThiMGUtY2UxYWVkNGY2ZjljXkEyXkFqcGc@._V1_.jpg",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = new Guid("4491b6f5-2a11-4c4c-8c6b-c371f47d2152"),
                            Description = "The lives of two hitmen, a boxer, and a gangster intertwine in four tales of violence and redemption.",
                            Director = "Quentin Tarantino",
                            Duration = 154,
                            Genre = "Crime",
                            ImageUrl = "https://www.tallengestore.com/cdn/shop/products/PulpFiction-JohnTravoltaAndSamuelLJackson-MovieStill1_d3db6d19-235a-45aa-97b2-ab690665c224.jpg?v=1684129898",
                            IsDeleted = false,
                            ReleaseDate = new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pulp Fiction"
                        });
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Ticket identifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key to the user bought the ticket");

                    b.Property<Guid>("CinemaMovieId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key to the CinemaMovie projection entity");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Ticket Price");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CinemaMovieId");

                    b.ToTable("Tickets", t =>
                        {
                            t.HasComment("Tickets in the system");
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CinemaApp.Data.Models.ApplicationUserMovie", b =>
                {
                    b.HasOne("CinemaApp.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Watchlist")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CinemaApp.Data.Models.Movie", "Movie")
                        .WithMany("MovieApplicationUsers")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CinemaApp.Data.Models.CinemaMovie", b =>
                {
                    b.HasOne("CinemaApp.Data.Models.Cinema", "Cinema")
                        .WithMany("CinemaMovies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CinemaApp.Data.Models.Movie", "Movie")
                        .WithMany("MovieCinemas")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Ticket", b =>
                {
                    b.HasOne("CinemaApp.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Tickets")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CinemaApp.Data.Models.CinemaMovie", "CinemaMovie")
                        .WithMany("Tickets")
                        .HasForeignKey("CinemaMovieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("CinemaMovie");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("CinemaApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("CinemaApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("CinemaApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaApp.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Tickets");

                    b.Navigation("Watchlist");
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Cinema", b =>
                {
                    b.Navigation("CinemaMovies");
                });

            modelBuilder.Entity("CinemaApp.Data.Models.CinemaMovie", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Movie", b =>
                {
                    b.Navigation("MovieApplicationUsers");

                    b.Navigation("MovieCinemas");
                });
#pragma warning restore 612, 618
        }
    }
}

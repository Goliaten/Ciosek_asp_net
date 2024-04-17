﻿// <auto-generated />
using System;
using Ciosek_asp_net.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ciosek_asp_net.Migrations
{
    [DbContext(typeof(FilmyContext))]
    [Migration("20240417075310_plakat")]
    partial class plakat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ciosek_asp_net.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Data_dodania")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Rezyser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwaPlakatu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaId");

                    b.ToTable("Filmy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cena = 19m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2350),
                            KategoriaId = 1,
                            Opis = "Piasek",
                            Rezyser = "A",
                            Tytul = "Diuna",
                            nazwaPlakatu = "plakatDune.webp"
                        },
                        new
                        {
                            Id = 2,
                            Cena = 20m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2395),
                            KategoriaId = 2,
                            Opis = "Łyżeczka",
                            Rezyser = "B",
                            Tytul = "Incepcja",
                            nazwaPlakatu = "plakatIncepcja.webp"
                        },
                        new
                        {
                            Id = 3,
                            Cena = 15m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2405),
                            KategoriaId = 2,
                            Opis = "Karty",
                            Rezyser = "C",
                            Tytul = "Iluzja",
                            nazwaPlakatu = "plakatIluzja.webp"
                        },
                        new
                        {
                            Id = 4,
                            Cena = 10m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2414),
                            KategoriaId = 1,
                            Opis = "Robaki",
                            Rezyser = "B",
                            Tytul = "Starship Troopers",
                            nazwaPlakatu = "plakatTroopers.webp"
                        },
                        new
                        {
                            Id = 5,
                            Cena = 20m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2422),
                            KategoriaId = 1,
                            Opis = "High ground",
                            Rezyser = "D",
                            Tytul = "Gwiedne Wojny",
                            nazwaPlakatu = "plakatStarWars.webp"
                        },
                        new
                        {
                            Id = 6,
                            Cena = 18m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2430),
                            KategoriaId = 3,
                            Opis = "Telewizor",
                            Rezyser = "E",
                            Tytul = "The Ring",
                            nazwaPlakatu = "plakatTheRing.webp"
                        },
                        new
                        {
                            Id = 7,
                            Cena = 18m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2438),
                            KategoriaId = 1,
                            Opis = "Niebiescy indianie",
                            Rezyser = "E",
                            Tytul = "Avatar",
                            nazwaPlakatu = "plakatAvatar.webp"
                        },
                        new
                        {
                            Id = 8,
                            Cena = 17m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2559),
                            KategoriaId = 4,
                            Opis = "Chińska magia",
                            Rezyser = "F",
                            Tytul = "Avatar",
                            nazwaPlakatu = "plakatAvatarAang.webp"
                        },
                        new
                        {
                            Id = 9,
                            Cena = 16m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2573),
                            KategoriaId = 2,
                            Opis = "Okulary",
                            Rezyser = "B",
                            Tytul = "Matrix",
                            nazwaPlakatu = "plakatMatrix.webp"
                        },
                        new
                        {
                            Id = 10,
                            Cena = 14m,
                            Data_dodania = new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2577),
                            KategoriaId = 5,
                            Opis = "Rodzina",
                            Rezyser = "D",
                            Tytul = "Szybcy  i Wściekli",
                            nazwaPlakatu = "plakatSzybcy.webp"
                        });
                });

            modelBuilder.Entity("Ciosek_asp_net.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nazwa = "Kosmiczne fantasy",
                            Opis = "AA"
                        },
                        new
                        {
                            Id = 2,
                            Nazwa = "Fikcja naukowa",
                            Opis = "BB"
                        },
                        new
                        {
                            Id = 3,
                            Nazwa = "Horror",
                            Opis = "CC"
                        },
                        new
                        {
                            Id = 4,
                            Nazwa = "Magiczne fantasy",
                            Opis = "DD"
                        },
                        new
                        {
                            Id = 5,
                            Nazwa = "Wyścigowy",
                            Opis = "EE"
                        });
                });

            modelBuilder.Entity("Ciosek_asp_net.Models.Film", b =>
                {
                    b.HasOne("Ciosek_asp_net.Models.Kategoria", "Kategoria")
                        .WithMany("Filmy")
                        .HasForeignKey("KategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("Ciosek_asp_net.Models.Kategoria", b =>
                {
                    b.Navigation("Filmy");
                });
#pragma warning restore 612, 618
        }
    }
}
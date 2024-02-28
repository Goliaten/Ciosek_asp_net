using Ciosek_asp_net.Models;
using Microsoft.EntityFrameworkCore;

namespace Ciosek_asp_net.DAL
{
    public class FilmyContext : DbContext
    {
        public FilmyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Film> Filmy { get; set; }

        public DbSet<Kategoria> Kategorie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Film>().HasData(
                new Film() { Id = 1, Tytul = "Diuna", Opis = "Piasek", Cena = 19, Data_dodania = DateTime.Now, Rezyser = "A", KategoriaId=1},
                new Film() { Id = 2, Tytul = "Incepcja", Opis = "Łyżeczka", Cena = 20, Data_dodania = DateTime.Now, Rezyser = "B", KategoriaId=2},
                new Film() { Id = 3, Tytul = "Iluzja", Opis = "Karty", Cena = 15, Data_dodania = DateTime.Now, Rezyser = "C", KategoriaId=2},
                new Film() { Id = 4, Tytul = "Starship Troopers", Opis = "Robaki", Cena = 10, Data_dodania = DateTime.Now, Rezyser = "B", KategoriaId=1},
                new Film() { Id = 5, Tytul = "Gwiedne Wojny", Opis = "High ground", Cena = 20, Data_dodania = DateTime.Now, Rezyser = "D", KategoriaId=1},
                new Film() { Id = 6, Tytul = "The Ring", Opis = "Telewizor", Cena = 18, Data_dodania = DateTime.Now, Rezyser = "E", KategoriaId=3},
                new Film() { Id = 7, Tytul = "Avatar", Opis = "Niebiescy indianie", Cena = 18, Data_dodania = DateTime.Now, Rezyser = "E", KategoriaId=1},
                new Film() { Id = 8, Tytul = "Avatar", Opis = "Chińska magia", Cena = 17, Data_dodania = DateTime.Now, Rezyser = "F", KategoriaId=4},
                new Film() { Id = 9, Tytul = "Matrix", Opis = "Okulary", Cena = 16, Data_dodania = DateTime.Now, Rezyser = "B", KategoriaId=2},
                new Film() { Id = 10, Tytul = "Szybcy  i Wściekli", Opis = "Rodzina", Cena = 14, Data_dodania = DateTime.Now, Rezyser = "D", KategoriaId=5}
                );
            modelBuilder.Entity<Kategoria>().HasData(
                new Kategoria() { Id = 1, Nazwa = "Kosmiczne fantasy", Opis = "AA" },
                new Kategoria() { Id = 2, Nazwa = "Fikcja naukowa", Opis = "BB" },
                new Kategoria() { Id = 3, Nazwa = "Horror", Opis = "CC" },
                new Kategoria() { Id = 4, Nazwa = "Magiczne fantasy", Opis = "DD" },
                new Kategoria() { Id = 5, Nazwa = "Wyścigowy", Opis = "EE" }
                );
        }
    }
}

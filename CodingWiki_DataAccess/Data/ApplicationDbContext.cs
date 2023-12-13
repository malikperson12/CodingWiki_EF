using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Sensitive information
            optionsBuilder.UseSqlServer("Server=MPSPC2022\\MSSQLSERVER02;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.Author_Id, u.Book_Id });

            ////Book data (1)
            ////1st way to seed data
            //modelBuilder.Entity<Book>().HasData(
            //    new Book { Book_Id = 1, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m, Publisher_Id = 1 },
            //    new Book { Book_Id = 2, Title = "Fortune of Time", ISBN = "12123B12", Price = 11.99m, Publisher_Id = 1 }
            //    );

            ////Book data (2)
            ////2nd way to seed data 
            //var bookList = new Book[]
            //{
            //    new Book { Book_Id = 3, Title = "Fake Sunday", ISBN = "77652", Price = 20.99m, Publisher_Id = 2 },
            //    new Book { Book_Id = 4, Title = "Cookie Jar", ISBN = "CC12B12", Price = 25.99m, Publisher_Id = 3 },
            //    new Book { Book_Id = 5, Title = "Cloudy Forest", ISBN = "90392B33", Price = 40.99m, Publisher_Id = 3}
            //};
            //modelBuilder.Entity<Book>().HasData(bookList);

            ////Publisher data
            //modelBuilder.Entity<Publisher>().HasData(
            //    new Publisher { Publisher_Id = 1, Name = "Pub 1 Jimmy", Location = "Chicagao"},
            //    new Publisher { Publisher_Id = 2, Name = "Pub 2 John", Location = "New York"},
            //    new Publisher { Publisher_Id = 3, Name = "Pub 3 Ben", Location = "Hawaii"}
            //    );
        }
    }
}

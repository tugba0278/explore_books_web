using Microsoft.EntityFrameworkCore;
using System;

namespace explore_books.Pages.PROJECT
{
    public class db: DbContext
    {
        public db(DbContextOptions<db> options) : base(options)
        {
        }

        // Veritabanı tablolarınızı burada DbSet olarak tanımlayın
        public DbSet<Book> Books => Set<Book>();

    }
    public class Book
    {
        public int Id { get; set; } // Kitabın benzersiz tanımlayıcısı
        public string Title { get; set; } // Kitabın adı
        public string Author { get; set; } // Kitabın yazarı
        public string ImageUrl { get; set; } // Kitabın resminin URL'si
    }

}

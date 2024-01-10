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
        public DbSet<Request> Requests => Set<Request>();
        public DbSet<GenreSelection> Genres => Set<GenreSelection>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();

    }
    public class Request
    {
        public int Id { get; set; } // Kitabın benzersiz tanımlayıcısı
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string PhoneNumber { get; set; }
        public string RegisterEmail { get; set; }
        public string RegisterPassword { get; set; }
    }
    public class GenreSelection
    {
        public int Id { get; set; } // Kitabın benzersiz tanımlayıcısı
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BookGenre { get; set; }
    }
    public class Book
    {
        public int bookId { get; set; } // Kitabın benzersiz tanımlayıcısı
        public string bookName { get; set; } // Kitabın adı
        public string author { get; set; } // Kitabın yazarı
        public string bookImage { get; set; } // Kitabın resmi
    }
    public class Author
    {
        public int authorId { get; set; } // yazarın benzersiz tanımlayıcısı
        public string authorName { get; set; } // yazarın adı
        public string authorImage { get; set; } // yazarın resmi
    }

}

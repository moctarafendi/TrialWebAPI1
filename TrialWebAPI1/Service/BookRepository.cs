using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialWebAPI1.Entity;
using TrialWebAPI1.IService;

namespace TrialWebAPI1.Service
{
    public class BookRepository : IBookRepository
    {
       // private List<Book> _books;

        private readonly PustakaDbContext _dbContext;
        public BookRepository(PustakaDbContext dbContext)
        {
            _dbContext = dbContext;
            //if (_books == null)
            //    InitializeBooks();
        }

        //private void InitializeBooks()
        //{
        //    _books = new List<Book>()
        //    {
        //        new Book
        //        {
        //            ID = 1,
        //            Judul = "Xamarin android - Mudah Membangun Aplikasi Mobile",
        //            Penulis = "Junindar",
        //            Penerbit = "EbookUID",
        //            Deskripsi = "",
        //            Status = true,
        //            Gambar = "xamarin-form.jpg"
        //        },
        //        new Book
        //        {
        //            ID = 2,
        //            Judul = "ASP .NET - Mudah Membangun Aplikasi Web",
        //            Penulis = "Junindar",
        //            Penerbit = "EbookUID",
        //            Deskripsi = "",
        //            Status = true,
        //            Gambar = "xamarin-form.jpg"
        //        }
        //    };
        //}

        IEnumerable<Book> IBookRepository.GetAllBooks()
        {
            //return _books;
            return _dbContext.Books;
        }

        Book IBookRepository.GetBookById(int bookId)
        {
            //return _books.FirstOrDefault(x => x.ID == bookId);
            return _dbContext.Books.FirstOrDefault(x => x.ID == bookId);
        }
    }
}

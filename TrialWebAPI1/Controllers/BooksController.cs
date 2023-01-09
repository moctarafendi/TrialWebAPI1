using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialWebAPI1.Entity;
using TrialWebAPI1.IService;

namespace TrialWebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = _bookRepository.GetAllBooks();

            return Ok(books);
        }

        [HttpGet("{bookId}",Name="GetBook")]
        public ActionResult<Book> GetBook(int bookId)
        {
            var book = _bookRepository.GetBookById(bookId);
            return Ok(book);
        }

    }
}


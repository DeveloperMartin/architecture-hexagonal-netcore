using AH_DDD_ASP.book_management.application;
using AH_DDD_ASP.book_management.domain;
using Microsoft.AspNetCore.Mvc;

namespace AH_DDD_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var books = _bookService.getBooks();
            return Ok(books);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            try
            {
                if (book == null)
                {
                    return BadRequest();
                }

                var newBook = _bookService.addBook(book.IdBook, book.Title, book.Sinopsis, book.Score, book.State);
                return CreatedAtAction(nameof(Get), new { id = newBook.IdBook }, newBook);
            } catch (Exception e) 
            {
                return BadRequest(e.Message);
            }
        }


    }
}

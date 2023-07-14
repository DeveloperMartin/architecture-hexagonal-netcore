using AH_DDD_ASP.book_management.domain;
using AH_DDD_ASP.book_management.domain.interfaces;

namespace AH_DDD_ASP.book_management.application
{
    public class BookService
    {
        private IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book addBook(int idBook, string title, string sinopsis, int score, int state)
        {
            Book book = new Book(idBook, title, sinopsis, score, state);
            return bookRepository.addBook(book);
        }

        public Book getBook(int idBook)
        {
            Book book = bookRepository.getBookById(idBook);
            return book;
        }

        public Book getBook(string title)
        {
            Book book = bookRepository.getBookByTitle(title);
            return book;
        }

        public List<Book> getBooks()
        {
            return bookRepository.getBooks();
        }

        public Book UpdateTitle(int idBook, string newTitle)
        {
            var book = getBook(idBook);
            book.UpdateTitle(newTitle);
            bookRepository.UpdateBook(book);
            return book;
        }

        public Book UpdateScore(int idBook, int newScore)
        {
            var book = getBook(idBook);
            book.UpdateScore(newScore);
            bookRepository.UpdateBook(book);
            return book;
        }

        public Book UpdateState(int idBook, int newState)
        {
            var book = getBook(idBook);
            book.UpdateState(newState);
            bookRepository.UpdateBook(book);
            return book;
        }
    }
}

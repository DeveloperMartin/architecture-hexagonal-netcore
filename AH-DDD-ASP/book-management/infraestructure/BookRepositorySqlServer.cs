using AH_DDD_ASP.book_management.domain.interfaces;
using Database;

namespace AH_DDD_ASP.book_management.infraestructure
{
    public class BookRepositorySqlServer : IBookRepository
    {
        private LibraryContext _libraryContext;

        public BookRepositorySqlServer(LibraryContext context)
        {
            _libraryContext = context;
        }

        public domain.Book addBook(domain.Book book)
        {
            var domainBook = new domain.Book(book.IdBook, book.Title, book.Sinopsis, book.Score, book.State);

            var dbBook = new Database.Book
            {
                IdBook = book.IdBook,
                Title = book.Title,
                Sinopsis = book.Sinopsis,
                Score = book.Score,
                State = book.State
            };

            domainBook.UpdateId(dbBook.IdBook);
            _libraryContext.Books.Add(dbBook);
            _libraryContext.SaveChanges();

            return book;
        }

        public domain.Book getBookById(int idBook)
        {
            throw new NotImplementedException();
        }

        public domain.Book getBookByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<domain.Book> getBooks()
        {
            var dbBooks = _libraryContext.Books.ToList();
            var domainBooks = new List<domain.Book>();

            foreach (var dbBook in dbBooks)
            {
                domainBooks.Add(new domain.Book(
                    dbBook.IdBook,
                    dbBook.Title,
                    dbBook.Sinopsis,
                    dbBook.Score,
                    dbBook.State
                    ));
            }

            return domainBooks;
        }

        public domain.Book UpdateBook(domain.Book book)
        {
            throw new NotImplementedException();
        }

        public domain.Book UpdateScore(int id, int newScore)
        {
            throw new NotImplementedException();
        }

        public domain.Book UpdateState(int id, int newState)
        {
            throw new NotImplementedException();
        }

        public domain.Book UpdateTitle(int id, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}

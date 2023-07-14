namespace AH_DDD_ASP.book_management.domain.interfaces
{
    public interface IBookRepository
    {
        Book addBook(Book book);
        Book getBookById(int idBook);
        Book getBookByTitle(string title);
        List<Book> getBooks();
        Book UpdateTitle(int id, string newTitle);
        Book UpdateScore(int id, int newScore);
        Book UpdateState(int id, int newState);
        Book UpdateBook(Book book);
    }
}

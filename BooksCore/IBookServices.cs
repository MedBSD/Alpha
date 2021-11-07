using System.Collections.Generic;

namespace BooksCore
{
    public interface IBookServices
    {
        List<Book> GetBooksAsync();
    }
}
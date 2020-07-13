using MyWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPISample.Services
{
    public class BooksService : IBooksService
    {
        private List<Book> _books = new List<Book>()
        {
            new Book {BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press"},
            new Book {BookId = 2, Title = "Professional C# 7", Publisher = "Wrox Press"}
        };

        public Task<IEnumerable<Book>> GetBooksAsync()
        {
            return Task<IEnumerable<Book>>.FromResult<IEnumerable<Book>>(_books);
        }

        public Task<Book> AddBookAsync(Book book)
        {
            var nextId = _books.Max(b => b.BookId) + 1;
            book.BookId = nextId;
            _books.Add(book);
            return Task.FromResult(book);
        }

        public Task<Book> GetBookByIdAsync(int id)
        {
            return Task.FromResult(_books.SingleOrDefault(b => b.BookId == id));
        }
    }
}

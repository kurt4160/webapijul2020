using MyWebAPISample.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPISample.Services
{
    public class BooksService : IBooksService
    {
        private readonly ConcurrentDictionary<int, Book> _books;

        public BooksService()
        {
            _books = new ConcurrentDictionary<int, Book>();
            _books.TryAdd(1, new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" });
            _books.TryAdd(2, new Book { BookId = 2, Title = "Professional C# 7", Publisher = "Wrox Press" });
        }

        public Task<IEnumerable<Book>> GetBooksAsync()
        {
            return Task<IEnumerable<Book>>.FromResult<IEnumerable<Book>>(_books.Values.ToList());
        }

        private readonly object lockAddBook = new object();
        public Task<Book> AddBookAsync(Book book)
        {
            lock (lockAddBook)
            {
                var nextId = _books.Values.Max(b => b.BookId) + 1;
                book.BookId = nextId;
                _books.TryAdd(nextId, book);
            }

            return Task.FromResult(book);
        }

        public Task<Book?> GetBookByIdAsync(int id)
        {
            if (_books.TryGetValue(id, out Book? book))
            {
                return Task.FromResult<Book?>(book);
            }
            else
            {
                return Task.FromResult<Book?>(null);
            }

        }
    }
}

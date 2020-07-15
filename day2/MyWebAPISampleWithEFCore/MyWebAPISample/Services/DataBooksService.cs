using Microsoft.EntityFrameworkCore;
using MyWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPISample.Services
{
    public class DataBooksService : IBooksService
    {
        private readonly BooksContext _booksContext;
        public DataBooksService(BooksContext booksContext)
        {
            _booksContext = booksContext;
        }
        public Task<Book> AddBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<Book?> GetBookByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            var books = await _booksContext.Books.ToListAsync();
            return books;
        }
    }
}

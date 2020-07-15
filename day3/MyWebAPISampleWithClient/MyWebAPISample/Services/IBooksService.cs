using MyWebAPISample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWebAPISample.Services
{
    public interface IBooksService
    {
        Task<Book> AddBookAsync(Book book);
        Task<Book?> GetBookByIdAsync(int id);
        Task<IEnumerable<Book>> GetBooksAsync();
    }
}
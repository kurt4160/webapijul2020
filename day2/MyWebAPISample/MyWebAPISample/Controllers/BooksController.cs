using Microsoft.AspNetCore.Mvc;
using MyWebAPISample.Models;
using MyWebAPISample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyWebAPISample.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
      //   [ProducesResponseType(typeof(IEnumerable<Book>), 200)]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _booksService.GetBooksAsync();
            return Ok(books);
        }

        [HttpGet("{id}", Name = nameof(GetBookById))]
        [ProducesResponseType(typeof(Book), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _booksService.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        /// <summary>
        /// <
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        // TODO: get named status code
        [HttpPost]    
        [ProducesResponseType(typeof(Book), 201)]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            var retBook = await _booksService.AddBookAsync(book);
            return CreatedAtRoute(nameof(GetBookById), new { id = retBook.BookId }, retBook);
        }
    }
}

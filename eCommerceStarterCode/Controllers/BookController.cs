using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route(V)]
    [ApiController]
    public class BookController : ControllerBase
    {
        private const string V = "api/";
        private ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("book")]

        public IActionResult GetBook()
        {
            // Retrieve all product from database
            var books = _context.Book.ToList();
            return Ok(books);
        }

        //id or isbn??? isbn filter/search? 
        //ID is still our primary key.  We included ISBN more because people search for books that way and it's a nice touch. -Midnight

        [HttpGet("book/{id:int}")]

        public IActionResult GetBookId(int id)
        {
            // Retrieve product by ID from database
            var BookId = _context.Book.Find(id);
            return Ok(BookId);
        }

        [HttpPost("book")]
        public IActionResult NewBook([FromBody] Models.Book value)
        {
            _context.Book.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpPut("book/edit/{Id}")]
        public IActionResult EditBook(int Id, [FromBody] Book value)
        {
            //Edit Single Book
            var book = _context.Book.Where(u => u.BookId == Id).SingleOrDefault();
            if (book == null)
            {
                return NotFound("There is no user with that Id.");
            }
            book.Title = value.Title;
            book.Author = value.Author;
            book.Description = value.Description;
            book.Genre = value.Genre;
            book.ReleaseYear = value.ReleaseYear;
            book.ISBN = value.ISBN;
            book.Price = value.Price;

            _context.Book.Update(book);
            _context.SaveChanges();
            return StatusCode(201, book);
        }

        [HttpDelete("book/delete/{id:int}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var bookToDelete = _context.Book.Where(u => u.BookId == id).SingleOrDefault();
            if (bookToDelete == null)
            {
                return NotFound($"book with BookId = {id} not found");
            }
            _context.Book.Remove(bookToDelete);
            _context.SaveChanges();
            return StatusCode(202, bookToDelete);
        }
        


    }
}

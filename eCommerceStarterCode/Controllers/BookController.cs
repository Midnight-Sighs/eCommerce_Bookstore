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
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
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

        [HttpGet("{id:int}")]

        public IActionResult GetBookId(int id)
        {
            // Retrieve product by ID from database
            var BookId = _context.Book.Find(id);
            return Ok(BookId);
        }
    }
}

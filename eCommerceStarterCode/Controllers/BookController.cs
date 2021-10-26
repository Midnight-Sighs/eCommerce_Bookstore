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

    }
}

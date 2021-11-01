using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
        private IWebHostEnvironment _hostEnvironment;

        public string Id { get; private set; }

        public BookController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        [HttpGet("book")]

        //public IActionResult GetAllBook()
        //{
        //    // Retrieve all product from database
        //    var books = _context.Book.ToList();
        //    return Ok(books);
        //}
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Book
                .Select(x => new Book()
                {
                    BookId = x.BookId,
                    Title = x.Title,
                    Author = x.Author,
                    Description = x.Description,
                    Genre = x.Genre,
                    ReleaseYear = x.ReleaseYear,
                    ISBN = x.ISBN,
                    Price = x.Price,
                    Id = x.Id,
                    ImagePath = x.ImagePath,
                    ImageSrc = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImagePath)
                })
                .ToListAsync();
        }

        [HttpGet("book/{id:int}")]

        public IActionResult GetBookId(int id)
        {
            // Retrieve product by ID from database
            var book = _context.Book.Where(b => b.BookId == id).SingleOrDefault();
            return Ok(book);

        }
        [HttpGet("book/seller/{sellerid}")]

        public async Task<ActionResult<IEnumerable<Book>>> GetBooks(string sellerid)
        {
            // Retrieve product by ID from database
            return await _context.Book.Where(b => b.Id == sellerid)
                .Select(x => new Book()
                 {
                     BookId = x.BookId,
                     Title = x.Title,
                     Author = x.Author,
                     Description = x.Description,
                     Genre = x.Genre,
                     ReleaseYear = x.ReleaseYear,
                     ISBN = x.ISBN,
                     Price = x.Price,
                     Id = x.Id,
                     ImagePath = x.ImagePath,
                     ImageSrc = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImagePath)
                 })
                .ToListAsync();
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        [HttpPost("book")]
        //public async Task<ActionResult<Book>> NewBook([FromForm] Book value)
        public async Task<IActionResult> Post([FromForm]Book value)
        {

                if (value.Image == null)
                {
                }
                else
                {
                    value.ImagePath = await SaveImage(value.Image);
                }


                _context.Book.Add(value);
                _context.SaveChanges();

            return StatusCode(201, value);
            
            //catch (Exception)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            //}

            //string uniqueFileName = await SaveImage(value.Image);

            //_context.Book.Add(new Book()
            //    {
            //        Id = value.Id,
            //        Title = value.Title,
            //        Author = value.Author,
            //        Description = value.Description,
            //        Genre = value.Genre,
            //        ReleaseYear = value.ReleaseYear,
            //        ISBN = value.ISBN,
            //        Price = value.Price,
            //        ImageSrc = uniqueFileName,
            //     });

            //_context.Book.Add(newbook);
            //await _context.SaveChangesAsync();
            //return StatusCode(204, value);
        }
        [HttpPut("book/edit/{Id}")]
        public IActionResult EditBook(int Id, [FromBody] Book value)
        {
            //Edit Single Book
            var book = _context.Book.Where(u => u.BookId == Id).SingleOrDefault();
            if (book == null)
            {
                return NotFound("There is no book with that Id.");
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

        [NonAction]
        public async Task<string> SaveImage(IFormFile Image)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(Image.FileName).Take(10).ToArray());
            imageName = imageName + DateTime.Now.ToString("yymmssff") + Path.GetExtension(Image.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            using var fileStream = new FileStream(imagePath, FileMode.Create);
            {
                await Image.CopyToAsync(fileStream);
            }
            return imageName;
        }

    }
}

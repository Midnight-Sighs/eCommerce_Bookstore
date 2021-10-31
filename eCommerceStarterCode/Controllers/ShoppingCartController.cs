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
    public class ShoppingCartController : ControllerBase
    {
        private const string V = "api/";
        private ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet ("shoppingCart")]

        public IActionResult GetCart()
        {
            //everthing that is currently in the cart
            var cart = _context.ShoppingCart.ToList();
            return Ok(cart);
        }

        [HttpGet("shoppingCart/{userid}")]

        public IActionResult GetMyCart(string userid)
        {
            //everthing that is currently in the cart
            var cart = _context.ShoppingCart.Where(u => u.UserId == userid);
            return Ok(cart);
        }

        [HttpDelete("shoppingCart/{userid}/delete/{Id:int}")]

        public IActionResult DeleteBook(string userid, int Id)
        {
            
            var bookToDelete = _context.ShoppingCart
                .Where(u => u.UserId == userid && u.BookId == Id)
                .SingleOrDefault();

             if (bookToDelete == null)
            {
                return NotFound($"book with BookId = {Id} not found");
            }
            _context.ShoppingCart.Remove(bookToDelete);
            _context.SaveChanges();
            return StatusCode(200, bookToDelete);
        }

        [HttpPost("shoppingCart/addBook/")]

        public IActionResult AddBook([FromBody] ShoppingCart value)
        {
            _context.ShoppingCart.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpPut("shoppingCart/update/{userId}/{Id:int}")]

        public IActionResult UpdateCart(string userId, int Id, [FromBody] ShoppingCart value)
        {
            var cart = _context.ShoppingCart.Where(u => u.UserId == userId && u.BookId == Id).SingleOrDefault();
            if(cart == null)
            {
                return NotFound("No shopping cart that meets that criteria");
            }

            cart.Quantity = value.Quantity;

            _context.ShoppingCart.Update(cart);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }

}        
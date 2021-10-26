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

       // [HttpDelete("shoppingCart/bookId:int")]

        //public IActionResult DeleteBook(int bookId)
        //{
        //    _context.ShoppingCart.Where(s=>s.BookId==bookId).Remove(s=>s.BookId==bookId).SingleOrDefault();
        //    _context.SaveChanges();
        //    return StatusCode(200, bookId);
        //}

        //[HttpPatch("shoppingCart/bookId:int")]

        //public IActionResult AddBook(int bookId)
        //{
        //    _context.ShoppingCart.Add(bookId).SingleOrDefault();
        //    _context.SaveChanges();
        //    return StatusCode(201, bookId);
        //}
    }

}        
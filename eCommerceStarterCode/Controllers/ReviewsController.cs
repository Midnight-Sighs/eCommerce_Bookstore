using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route(V)]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private const string V = "api/";
        private ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("reviews")]
        public IActionResult GetAllReviews()
        {
            //all reviews from database
            var reviews = _context.Reviews.ToList();
            return Ok(reviews);
        }

        [HttpGet("reviews/{reviewId:int}")]

        public IActionResult GetReview(int reviewId)
        {
            var review = _context.Reviews.Find(reviewId);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }

        [HttpPost("reviews/create")]
        public IActionResult PostUserrEVIEW([FromBody] Models.Reviews value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}

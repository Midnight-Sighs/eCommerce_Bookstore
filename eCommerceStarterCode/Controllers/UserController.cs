using AutoMapper;
using eCommerceStarterCode.ActionFilters;
using eCommerceStarterCode.Contracts;
using eCommerceStarterCode.DataTransferObjects;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private const string V = "{Id}";
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet(V)]
        public IActionResult GetAllUsers(string Id)
        {
            // Retrieve all users from database
            var user = _context.User.Where(u =>u.Id==Id);
            return Ok(user);
        }
        [HttpPut("api/users/{Id}")]
        public IActionResult EditUser(string Id, [FromBody] User value)
        {
            //Edit Single User
            var user = _context.User.Where(u =>u.Id == Id).SingleOrDefault();
            if (user == null)
            {
                return NotFound("There is no user with that Id.");
            }
            user.FirstName = value.FirstName;
            user.LastName = value.LastName;
            user.StreetAddress = value.StreetAddress;
            user.City = value.City;
            user.State = value.State;
            user.ZipCode = value.ZipCode;

            _context.User.Update(user);
            _context.SaveChanges();
            return StatusCode(201, user);
        }


    }

}

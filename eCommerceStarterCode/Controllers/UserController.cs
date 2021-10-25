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

namespace eCommerceStarterCode.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        
    }

}

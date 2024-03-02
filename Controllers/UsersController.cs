using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using DateApp.Data;
using DateApp.Entities;
using Microsoft.EntityFrameworkCore;


namespace DateApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // localhost... /api/users
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() // Action result nam pruza mogucnost da vratimo BadRequest
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user =await _context.Users.FindAsync(id);

            return user;
        }
    }
}
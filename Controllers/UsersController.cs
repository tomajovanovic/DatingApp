using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using DateApp.Data;
using DateApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace DateApp.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() // Action result nam pruza mogucnost da vratimo BadRequest
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            return user;
        }
    }
}
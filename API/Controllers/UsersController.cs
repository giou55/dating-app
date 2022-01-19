using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        // synchronous code
        // public ActionResult<IEnumerable<AppUser>> GetUsers()
        // {
        //     return _context.Users.ToList();
        // }

        // we write [HttpGet] to create a new endpoint for api/users
        [HttpGet]
        // asynchronous code
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            // another way instead of using the await keyword 
            // return _context.Users.ToListAsync().Result;
            return await _context.Users.ToListAsync();
        }

        // we write [HttpGet("{id}")] to create a new endpoint for api/users/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  

   [ApiController]
    [Route("api/[controller]")] 
        public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        // [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>>GetUsers()
        {
            
            return await _context.Users.ToListAsync();
           
           
        }
        //api/users/3
 
        [HttpGet("{id}")]
        public async Task< ActionResult<AppUser>>GetUser(int id)
        {
            return await _context.Users.FindAsync(id);  

            
           
        }

    }
}
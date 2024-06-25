using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthNotebook.DataService.Data;
using HealthNotebook.Entities;
using HealthNotebook.Entities.DbSet;
using HealthNotebook.Entities.Dtos.Incoming;

namespace HealthNotebook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    
    {
        private AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        //Get
        [HttpGet]
        public IActionResult GetUser()
        {
            var users = _context.Users.Where(x => x.Status == 1).ToList();
            return Ok(users);
        }
        //Post
        [HttpPost]

        public IActionResult AddUser(UserDto user)
        {
            var _user = new User();
            _user.Las )
            user.Status = 1;


            _context.Users.Add(user); 
            _context.SaveChanges();

            return Ok();
        }

        // Get All
       
        }

}
    



       
using Microsoft.AspNetCore.Mvc;
using BlogProject;
using BlogProject.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/user
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            IEnumerable<User> users = await _userService.GetAllUsers();
            return Ok(users);
        }

        // GET: api/user/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                User user = await _userService.GetUserById(id);
                if (user == null)
                    return NotFound();

                return Ok(user);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/user
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            try
            {
                User createdUser = await _userService.CreateUser(user);
                return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User user)
        {
            try
            {
                user.Id = id;
                User updatedUser = await _userService.UpdateUser(user);
                if (updatedUser == null)
                    return NotFound();

                return Ok(updatedUser);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                bool isDeleted = await _userService.DeleteUser(id);
                if (!isDeleted)
                    return NotFound();

                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }
    }
}

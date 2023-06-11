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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET: api/role
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            IEnumerable<Role> roles = await _roleService.GetAllRoles();
            return Ok(roles);
        }

        // GET: api/role/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            try
            {
                Role role = await _roleService.GetRoleById(id);
                if (role == null)
                    return NotFound();

                return Ok(role);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/role
        [HttpPost]
        public async Task<IActionResult> CreateRole(Role role)
        {
            try
            {
                Role createdRole = await _roleService.CreateRole(role);
                return CreatedAtAction(nameof(GetRoleById), new { id = createdRole.Id }, createdRole);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/role/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(int id, Role role)
        {
            try
            {
                role.Id = id;
                Role updatedRole = await _roleService.UpdateRole(role);
                if (updatedRole == null)
                    return NotFound();

                return Ok(updatedRole);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE: api/role/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            try
            {
                bool isDeleted = await _roleService.DeleteRole(id);
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

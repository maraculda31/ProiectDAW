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
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        // GET: api/tag
        [HttpGet]
        public async Task<IActionResult> GetAllTags()
        {
            IEnumerable<Tag> tags = await _tagService.GetAllTags();
            return Ok(tags);
        }

        // GET: api/tag/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagById(int id)
        {
            try
            {
                Tag tag = await _tagService.GetTagById(id);
                if (tag == null)
                    return NotFound();

                return Ok(tag);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/tag
        [HttpPost]
        public async Task<IActionResult> CreateTag(Tag tag)
        {
            try
            {
                Tag createdTag = await _tagService.CreateTag(tag);
                return CreatedAtAction(nameof(GetTagById), new { id = createdTag.Id }, createdTag);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/tag/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTag(int id, Tag tag)
        {
            try
            {
                tag.Id = id;
                Tag updatedTag = await _tagService.UpdateTag(tag);
                if (updatedTag == null)
                    return NotFound();

                return Ok(updatedTag);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE: api/tag/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(int id)
        {
            try
            {
                bool isDeleted = await _tagService.DeleteTag(id);
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

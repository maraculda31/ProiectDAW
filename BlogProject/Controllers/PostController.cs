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
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        // GET: api/post
        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            IEnumerable<Post> posts = await _postService.GetAllPosts();
            return Ok(posts);
        }

        // GET: api/post/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            try
            {
                Post post = await _postService.GetPostById(id);
                if (post == null)
                    return NotFound();

                return Ok(post);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/post
        [HttpPost]
        public async Task<IActionResult> CreatePost(Post post)
        {
            try
            {
                Post createdPost = await _postService.CreatePost(post);
                return CreatedAtAction(nameof(GetPostById), new { id = createdPost.Id }, createdPost);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/post/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, Post post)
        {
            try
            {
                post.Id = id;
                Post updatedPost = await _postService.UpdatePost(post);
                if (updatedPost == null)
                    return NotFound();

                return Ok(updatedPost);
            }
            catch (Exception ex)
            {
                // Handle exception and return appropriate response
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE: api/post/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            try
            {
                bool isDeleted = await _postService.DeletePost(id);
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

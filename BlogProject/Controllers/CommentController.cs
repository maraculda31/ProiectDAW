using Microsoft.AspNetCore.Mvc;
using BlogProject;
using BlogProject.Services;

namespace BlogProject.Controllers
{
    [ApiController]
    [Route("api/comments")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult GetAllComments()
        {
            var comments = _commentService.GetAllComments();
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public IActionResult GetCommentById(int id)
        {
            var comment = _commentService.GetCommentById(id);
            if (comment == null)
                return NotFound();

            return Ok(comment);
        }

        [HttpPost]
        public IActionResult CreateComment([FromBody] Comment comment)
        {
            if (comment == null)
                return BadRequest();

            var createdComment = _commentService.CreateComment(comment);
            return CreatedAtAction(nameof(GetCommentById), new { id = createdComment.Id }, createdComment);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateComment(int id, [FromBody] Comment updatedComment)
        {
            if (updatedComment == null || id != updatedComment.Id)
                return BadRequest();

            var existingComment = _commentService.GetCommentById(id);
            if (existingComment == null)
                return NotFound();

            _commentService.UpdateComment(updatedComment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            var existingComment = _commentService.GetCommentById(id);
            if (existingComment == null)
                return NotFound();

            _commentService.DeleteComment(id);
            return NoContent();
        }
    }
}


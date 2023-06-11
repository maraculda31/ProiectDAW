using BlogProject;
using BlogProject.Repositories;
using BlogProject.Repositories.CommentRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<IEnumerable<Comment>> GetAllComments()
        {
            return await _commentRepository.GetAllComments();
        }

        public async Task<Comment> GetCommentById(int id)
        {
            return await _commentRepository.GetCommentById(id);
        }

        public async Task<Comment> CreateComment(Comment comment)
        {
            return await _commentRepository.CreateComment(comment);
        }

        public async Task<Comment> UpdateComment(Comment comment)
        {
            return await _commentRepository.UpdateComment(comment);
        }

        public async Task<bool> DeleteComment(int id)
        {
            return await _commentRepository.DeleteComment(id);
        }
    }
}

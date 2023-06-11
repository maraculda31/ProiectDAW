using BlogProject.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Repositories.CommentRepository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogContext _context;

        public CommentRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task<Comment> GetByIdAsync(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public void Add(Comment comment)
        {
            _context.Comments.Add(comment);
        }

        public void Update(Comment comment)
        {
            _context.Comments.Update(comment);
        }

        public void Delete(Comment comment)
        {
            _context.Comments.Remove(comment);
        }

        Task<Comment> ICommentRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Comment>> ICommentRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        void ICommentRepository.Add(Comment comment)
        {
            throw new NotImplementedException();
        }

        void ICommentRepository.Update(Comment comment)
        {
            throw new NotImplementedException();
        }

        void ICommentRepository.Delete(Comment comment)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Comment>> ICommentRepository.GetAllComments()
        {
            throw new NotImplementedException();
        }

        Task<Comment> ICommentRepository.GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        Task<Comment> ICommentRepository.CreateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        Task<Comment> ICommentRepository.UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICommentRepository.DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        // Implement additional methods as needed
    }
}

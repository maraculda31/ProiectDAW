using BlogProject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetAllComments();
        Task<Comment> GetCommentById(int id);
        Task<Comment> CreateComment(Comment comment);
        Task<Comment> UpdateComment(Comment comment);
        Task<bool> DeleteComment(int id);
    }
}

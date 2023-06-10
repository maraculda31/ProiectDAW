namespace BlogProject.Repositories.CommentRepository
{
    public interface ICommentRepository
    {
        Task<Comment> GetByIdAsync(int id);
        Task<List<Comment>> GetAllAsync();
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        Task<IEnumerable<Comment>> GetAllComments();
        Task<Comment> GetCommentById(int id);
        Task<Comment> CreateComment(Comment comment);
        Task<Comment> UpdateComment(Comment comment);
        Task<bool> DeleteComment(int id);
        // Define additional methods as needed
    }
}

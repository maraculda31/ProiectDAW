namespace BlogProject.Repositories.CommentRepository
{
    public interface ICommentRepository
    {
        Task<Comment> GetByIdAsync(int id);
        Task<List<Comment>> GetAllAsync();
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        // Define additional methods as needed
    }
}

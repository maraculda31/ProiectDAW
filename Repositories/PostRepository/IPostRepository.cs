namespace BlogProject.Repositories.PostRepository
{
    public interface IPostRepository
    {
        Task<Post> GetByIdAsync(int id);
        Task<List<Post>> GetAllAsync();
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);
        // Define additional methods as needed
    }
}

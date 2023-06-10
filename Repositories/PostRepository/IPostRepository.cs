namespace BlogProject.Repositories.PostRepository
{
    public interface IPostRepository
    {
        Task<Post> GetByIdAsync(int id);
        Task<List<Post>> GetAllAsync();
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);
        Task<IEnumerable<Post>> GetAllPosts();
        Task<Post> GetPostById(int id);
        Task<Post> CreatePost(Post post);
        Task<Post> UpdatePost(Post post);
        Task<bool> DeletePost(int id);
        // Define additional methods as needed
    }
}

using BlogProject.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Repositories.PostRepository
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogContext _context;

        public PostRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task<Post> GetByIdAsync(int id)
        {
            return await _context.Posts.FindAsync(id);
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await _context.Posts.ToListAsync();
        }

        public void Add(Post post)
        {
            _context.Posts.Add(post);
        }

        public void Update(Post post)
        {
            _context.Posts.Update(post);
        }

        public void Delete(Post post)
        {
            _context.Posts.Remove(post);
        }

        public Task<IEnumerable<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> CreatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}

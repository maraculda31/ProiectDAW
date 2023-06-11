using BlogProject;
using BlogProject.Repositories;
using BlogProject.Repositories.PostRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _postRepository.GetAllPosts();
        }

        public async Task<Post> GetPostById(int id)
        {
            return await _postRepository.GetPostById(id);
        }

        public async Task<Post> CreatePost(Post post)
        {
            return await _postRepository.CreatePost(post);
        }

        public async Task<Post> UpdatePost(Post post)
        {
            return await _postRepository.UpdatePost(post);
        }

        public async Task<bool> DeletePost(int id)
        {
            return await _postRepository.DeletePost(id);
        }
    }
}

using BlogProject.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Repositories.TagRepository
{
    public class TagRepository : ITagRepository
    {
        private readonly BlogContext _context;

        public TagRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task<Tag> GetByIdAsync(int id)
        {
            return await _context.Tags.FindAsync(id);
        }

        public async Task<List<Tag>> GetAllAsync()
        {
            return await _context.Tags.ToListAsync();
        }

        public void Add(Tag tag)
        {
            _context.Tags.Add(tag);
        }

        public void Update(Tag tag)
        {
            _context.Tags.Update(tag);
        }

        public void Delete(Tag tag)
        {
            _context.Tags.Remove(tag);
        }

        // Implement additional methods as needed
    }
}

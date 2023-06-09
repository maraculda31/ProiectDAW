namespace BlogProject.Repositories.TagRepository
{
    public interface ITagRepository
    {
        Task<Tag> GetByIdAsync(int id);
        Task<List<Tag>> GetAllAsync();
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);
        // Define additional methods as needed
    }
}

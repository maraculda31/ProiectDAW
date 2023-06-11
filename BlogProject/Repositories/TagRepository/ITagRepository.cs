using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlogProject.Repositories.TagRepository
{
    public interface ITagRepository
    {
        Task<Tag> GetByIdAsync(int id);
        Task<List<Tag>> GetAllAsync();
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);
        Task<IEnumerable<Tag>> GetAllTags();
        Task<Tag> GetTagById(int id);
        Task<Tag> CreateTag(Tag tag);
        Task<Tag> UpdateTag(Tag tag);
        Task<bool> DeleteTag(int id);
        // Define additional methods as needed
    }
}

using BlogProject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetAllTags();
        Task<Tag> GetTagById(int id);
        Task<Tag> CreateTag(Tag tag);
        Task<Tag> UpdateTag(Tag tag);
        Task<bool> DeleteTag(int id);
    }
}

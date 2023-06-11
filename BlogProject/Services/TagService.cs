using BlogProject;
using BlogProject.Repositories;
using BlogProject.Repositories.TagRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<IEnumerable<Tag>> GetAllTags()
        {
            return await _tagRepository.GetAllTags();
        }

        public async Task<Tag> GetTagById(int id)
        {
            return await _tagRepository.GetTagById(id);
        }

        public async Task<Tag> CreateTag(Tag tag)
        {
            return await _tagRepository.CreateTag(tag);
        }

        public async Task<Tag> UpdateTag(Tag tag)
        {
            return await _tagRepository.UpdateTag(tag);
        }

        public async Task<bool> DeleteTag(int id)
        {
            return await _tagRepository.DeleteTag(id);
        }
    }
}


using BlogProject.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Repositories.RoleRepository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly BlogContext _context;

        public RoleRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task<Role> GetByIdAsync(int id)
        {
            return await _context.Roles.FindAsync(id);
        }

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<List<Role>> GetAllAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public void Add(Role role)
        {
            _context.Roles.Add(role);
        }

        public void Update(Role role)
        {
            _context.Roles.Update(role);
        }

        public void Delete(Role role)
        {
            _context.Roles.Remove(role);
        }

        public Task<Role> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetRoleById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Role> CreateRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<Role> UpdateRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRole(int id)
        {
            throw new NotImplementedException();
        }
    }

}

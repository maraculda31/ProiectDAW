using BlogProject;
using BlogProject.Repositories;
using BlogProject.Repositories.RoleRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            return await _roleRepository.GetAllRoles();
        }

        public async Task<Role> GetRoleById(int id)
        {
            return await _roleRepository.GetRoleById(id);
        }

        public async Task<Role> CreateRole(Role role)
        {
            return await _roleRepository.CreateRole(role);
        }

        public async Task<Role> UpdateRole(Role role)
        {
            return await _roleRepository.UpdateRole(role);
        }

        public async Task<bool> DeleteRole(int id)
        {
            return await _roleRepository.DeleteRole(id);
        }
    }
}

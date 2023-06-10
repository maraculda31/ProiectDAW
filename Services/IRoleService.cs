using BlogProject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetAllRoles();
        Task<Role> GetRoleById(int id);
        Task<Role> CreateRole(Role role);
        Task<Role> UpdateRole(Role role);
        Task<bool> DeleteRole(int id);
    }
}


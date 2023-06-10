namespace BlogProject.Repositories.RoleRepository
{
    public interface IRoleRepository
    {
        Task<Role> GetByIdAsync(int id);
        Task<Role> GetByNameAsync(string name);
        Task<List<Role>> GetAllAsync();
        void Add(Role role);
        void Update(Role role);
        void Delete(Role role);
        Task<IEnumerable<Role>> GetAllRoles();
        Task<Role> GetRoleById(int id);
        Task<Role> CreateRole(Role role);
        Task<Role> UpdateRole(Role role);
        Task<bool> DeleteRole(int id);
        // Define additional methods as needed
    }
}

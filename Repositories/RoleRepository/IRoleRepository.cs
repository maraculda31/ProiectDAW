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
        // Define additional methods as needed
    }
}

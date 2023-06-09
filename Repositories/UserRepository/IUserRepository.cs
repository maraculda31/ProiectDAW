namespace BlogProject.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<List<User>> GetAllAsync();
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        // Define additional methods as needed
    }
}

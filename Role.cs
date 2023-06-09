namespace BlogProject
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Add any additional properties as needed

        // Many-to-Many relationship with User
        public ICollection<UserRole> UserRoles { get; set; }
    }
}

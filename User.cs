namespace BlogProject
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // Add any additional properties as needed

        public ICollection<Post> Posts { get; set; } // One-to-Many relationship with Post
        public ICollection<Comment> Comments { get; set; } // One-to-Many relationship with Comment

        // Many-to-Many relationship with Role
        private ICollection<UserRole> _userRoles;
        public IEnumerable<UserRole> UserRoles => _userRoles;

        public User()
        {
            _userRoles = new List<UserRole>();
        }

        public void AddUserRole(UserRole userRole)
        {
            _userRoles.Add(userRole);
        }

        public void RemoveUserRole(UserRole userRole)
        {
            _userRoles.Remove(userRole);
        }
    }

}

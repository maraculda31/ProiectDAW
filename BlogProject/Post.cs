
namespace BlogProject



{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // One-to-Many relationship with User
        public ICollection<Tag> Tags { get; set; } // Many-to-Many relationship with Tag

        public ICollection<Comment> Comments { get; set; } // One-to-Many relationship with Comment
    }
}

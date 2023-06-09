namespace BlogProject
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; } // Many-to-Many relationship with Post
    }
}

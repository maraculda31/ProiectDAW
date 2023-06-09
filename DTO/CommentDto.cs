namespace BlogProject.DTO
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public PostDto Post { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
    }
}

namespace BlogExemple.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string PostId { get; set; }
    }
}
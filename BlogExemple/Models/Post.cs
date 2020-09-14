using System.Collections.Generic;

namespace BlogExemple.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
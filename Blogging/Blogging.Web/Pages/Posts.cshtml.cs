using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogging.Web.Pages
{
    public class PostsIndexModel : PageModel
    {
        public string Title { get; set; }
        public PostViewModel Post = new PostViewModel { Id = 1, Title = "Typescript"};

        public class PostViewModel
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }

        public void OnGet()
        {
            Title = !string.IsNullOrEmpty(Post.Title) ? Post.Title : "Test";
        }
    }
}
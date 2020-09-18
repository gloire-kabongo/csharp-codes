using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogging.Web.Pages
{
    public class PostModel : PageModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public void OnGet(int id, string title)
        {
            PostId = id;
            Title = title;
        }
    }
}
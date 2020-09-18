using Blogging.Data;
using Blogging.Logic.Entities;
using Blogging.Web.Interfaces;
using Blogging.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogging.Web.Pages
{
    public class AddPostModel : PageModel
    {
        private readonly BloggingContext context;
        private readonly IDateTime _dateTime;

        public AddPostModel(BloggingContext context, IDateTime dateTime)
        {
            this.context = context;
            _dateTime = dateTime;
        }

        [BindProperty]
        public PostViewModel Input { get; set; }
        public class PostViewModel
        {
            public string Body { get; set; }
            public string Title { get; set; }
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var post = new Post
            {
                Title = Input.Title,
                Body = Input.Body
            };

            var date = _dateTime.Now;

            context.Posts.Add(post);
            context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
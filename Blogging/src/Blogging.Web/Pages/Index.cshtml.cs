using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogging.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Blogging.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BloggingContext _context;

        public IndexModel(ILogger<IndexModel> logger, BloggingContext context)
        {
            _logger = logger;
            _context = context;
        }

        public List<PostViewModel> Posts { get; set; }

        public class PostViewModel
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
            public DateTime Date { get; set; }
        }

        public void OnGet()
        {
            Posts = _context.Posts
                        .Select(p => new PostViewModel
                        {
                            Id = p.Id,
                            Title = p.Title,
                            Body = p.Body
                        }).ToList();
        }
    }
}

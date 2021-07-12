using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesCore3._1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string Message { get; set; }
        public void OnGet()
        {
            ViewData["Name"] = "Yousef";
            ViewData["Age"] = 21;
            ViewData["Courses"] = new Course { Title = "ASP Core", Price = 120 };

        }

    }
    public class Course
    {
        public int Price { get; set; }
        public string Title { get; set; }
    }
}

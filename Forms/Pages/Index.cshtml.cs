using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Threading.Tasks;

namespace Forms.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public string EmailAddress { get; set; }

        public IFormFile Upload { get; set; }

        IHostingEnvironment _environment;

        public IndexModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public async Task OnPostAsync()
        {
            //var file = _enviroment.ContentRootPath + "/Uploads" + Upload.FileName;
            var file = Path.Combine(_environment.ContentRootPath, "Uploads", Upload.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }

        }
    }
}

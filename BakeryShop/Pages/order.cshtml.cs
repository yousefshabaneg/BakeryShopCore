using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BakeryShop.Pages
{
    public class orderModel : PageModel
    {
        private readonly BakeryShopContext _db;
        public orderModel(BakeryShopContext db) => _db = db;
        public Product Product { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _db.Products.FindAsync(Id);
        }
    }
}

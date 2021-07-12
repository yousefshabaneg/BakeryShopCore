using Microsoft.AspNetCore.Mvc;
using RazorPagesCore3._1.Services;
using System.Threading.Tasks;

namespace WebRazor.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        private IUserService _userService;
        public UserViewComponent(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var user = await _userService.GetUserAsync(id);
            return View(user);
        }
    }
}

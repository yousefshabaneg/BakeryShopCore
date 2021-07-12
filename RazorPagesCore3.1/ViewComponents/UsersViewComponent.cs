using Microsoft.AspNetCore.Mvc;
using RazorPagesCore3._1.Services;
using System.Threading.Tasks;

namespace WebRazor.ViewComponents
{
    public class UsersViewComponent : ViewComponent
    {
        private IUserService _userService;
        public UsersViewComponent(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userService.GetUsersAsync();
            return View(users);
        }
    }
}

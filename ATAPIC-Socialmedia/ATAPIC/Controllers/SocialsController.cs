using Microsoft.AspNetCore.Mvc;
using ATAPIC.Services;
using System.Threading.Tasks;

namespace ATAPIC.Controllers
{
    public class SocialsController : Controller
    {
        private readonly ISocialService _socialService;

        public SocialsController(ISocialService socialService)
        {
            _socialService = socialService;
        }

        public async Task<IActionResult> Index(string platform = "All", string search = "", int page = 1)
        {
            var posts = await _socialService.GetPostsAsync(platform, search, page);
            ViewBag.Platforms = new[] { "All", "LinkedIn", "Instagram", "Twitter", "YouTube", "Facebook" };
            ViewBag.CurrentPlatform = platform;
            ViewBag.Search = search;
            return View(posts);
        }
    }
}

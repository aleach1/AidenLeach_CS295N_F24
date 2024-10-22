using CelesteMountain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CelesteMountain.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<StoryPost> CurrentStories = new List<StoryPost>
        {
            new StoryPost
            {
                Title = "I just started speedrunning, and strawberry jam is great for tech.",
                Topic = "Speedrunning",
                StoryYear = 2024,
                Text = "I never really knew how to do a lot of speedrunning tech, but the libraries in strawberry jam really helped me.",
                Name = "Admin",
                DatePosted = DateTime.Now

            }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Stories()
        {
            return View();
        }

        public IActionResult PostStory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult PostStory(StoryPost newStory)
        {

            CurrentStories.Add(newStory);

            return RedirectToAction("Stories");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

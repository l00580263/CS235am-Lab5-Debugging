﻿
using Microsoft.AspNetCore.Mvc;

namespace HttpPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NickName(string name, string nickname)
        {
            return Content("Name: " + name + ", Nickname: " + nickname);
        }

        [HttpPost]
        public IActionResult FavFood(string main, string vegetable, string desert)
        {
            return Content("Main dish: " + main + ", Veggie: " + vegetable + ", Desert: " + desert);
        }

        [HttpPost]
        public IActionResult FavoriteMusic(string genre, string artist, string song)
        {
            return Content("Genre: " + genre + ", Artist: " + artist + ", Song: " + song);
        }

    }

}

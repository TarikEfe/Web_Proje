using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SözlükForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace SözlükForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Contex c = new Contex();

        [Authorize]
        public IActionResult Index(string searchString)
        {
            var bilgi = c.ForumSorus.Include(i => i.kullanici);
            var bilgiler = c.ForumSorus.OrderBy(r => Guid.NewGuid()).Take(10);
            ViewData["gundem"] = bilgiler;
            if (!String.IsNullOrEmpty(searchString))
            {
                bilgi = c.ForumSorus.Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici);
                var bilgibil = c.ForumSorus.Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici).Count();
                if (bilgibil == 0)
                {
                    bilgi = null;
                }
            }

            return View(bilgi);
        }

        public IActionResult Gundem()
        {
            var bilgi = c.ForumSorus.Include(i => i.kullanici).OrderBy(o => o.eklemeTarih);
            var bilgiler = c.ForumSorus.Include(i => i.kullanici).OrderByDescending(o => o.eklemeTarih);
            ViewData["gundem"] = bilgiler;
            return PartialView(bilgi);
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

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
using Microsoft.AspNetCore.Http;

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
        public IActionResult Index(string searchString)
        {
            var bilgi = c.ForumSorus.Include(i => i.kullanici);
            var bilgiler = c.ForumSorus.OrderBy(r => Guid.NewGuid()).Take(5);
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

        public IActionResult IndexKato(int id,string searchString)
        {
            switch (id)
            {
                case 1:
                    var bilgi1 = c.ForumSorus.Where(x => x.katego == Katego.Spor).Include(i => i.kullanici);
                    var bilgiler1 = c.ForumSorus.Where(x => x.katego == Katego.Spor).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler1;
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        bilgi1 = c.ForumSorus.Where(x => x.katego == Katego.Spor).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici);
                        var bilgibil = c.ForumSorus.Where(x => x.katego == Katego.Spor).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici).Count();
                        if (bilgibil == 0)
                        {
                            bilgi1 = null;
                        }
                    }
                    return View(bilgi1);

                case 2:
                    var bilgi2 = c.ForumSorus.Where(x => x.katego == Katego.Ekonomi).Include(i => i.kullanici);
                    var bilgiler2 = c.ForumSorus.Where(x => x.katego == Katego.Ekonomi).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler2;
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        bilgi2 = c.ForumSorus.Where(x => x.katego == Katego.Ekonomi).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici);
                        var bilgibil = c.ForumSorus.Where(x => x.katego == Katego.Ekonomi).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici).Count();
                        if (bilgibil == 0)
                        {
                            bilgi2 = null;
                        }
                    }
                    return View(bilgi2);
                case 3:
                    var bilgi3 = c.ForumSorus.Where(x => x.katego == Katego.Sağlık).Include(i => i.kullanici);
                    var bilgiler3 = c.ForumSorus.Where(x => x.katego == Katego.Sağlık).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler3;
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        bilgi2 = c.ForumSorus.Where(x => x.katego == Katego.Sağlık).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici);
                        var bilgibil = c.ForumSorus.Where(x => x.katego == Katego.Sağlık).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici).Count();
                        if (bilgibil == 0)
                        {
                            bilgi2 = null;
                        }
                    }
                    return View(bilgi3);
                case 4:
                    var bilgi4 = c.ForumSorus.Where(x => x.katego == Katego.Eğitim).Include(i => i.kullanici);
                    var bilgiler4 = c.ForumSorus.Where(x => x.katego == Katego.Eğitim).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler4;
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        bilgi2 = c.ForumSorus.Where(x => x.katego == Katego.Eğitim).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici);
                        var bilgibil = c.ForumSorus.Where(x => x.katego == Katego.Eğitim).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici).Count();
                        if (bilgibil == 0)
                        {
                            bilgi2 = null;
                        }
                    }
                    return View(bilgi4);
                default:
                    var bilgi5 = c.ForumSorus.Where(x => x.katego == Katego.Diğer).Include(i => i.kullanici);
                    var bilgiler5 = c.ForumSorus.Where(x => x.katego == Katego.Diğer).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler5;
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        bilgi2 = c.ForumSorus.Where(x => x.katego == Katego.Diğer).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici);
                        var bilgibil = c.ForumSorus.Where(x => x.katego == Katego.Diğer).Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici).Count();
                        if (bilgibil == 0)
                        {
                            bilgi2 = null;
                        }
                    }
                    return View(bilgi5);
            }
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

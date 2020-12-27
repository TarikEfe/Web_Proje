using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SözlükForum.Models;

namespace SözlükForum.Controllers
{
    public class KullaniciController : Controller
    {
        Contex c = new Contex();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult YeniKullanici()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKullanici(Kullanici k)
        {
            c.Kullanicis.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}

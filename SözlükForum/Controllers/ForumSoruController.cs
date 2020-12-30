using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SözlükForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace SözlükForum.Controllers
{
    public class ForumSoruController : Controller
    {

        Contex c = new Contex();
        public async Task<IActionResult> Detail(ForumSoru f)
        {
            var bilgi = c.ForumSorus.Where(s => s.Id == f.Id).Include(i => i.kullanici);
            return View(await bilgi.ToListAsync());
        }
        public IActionResult Kayit()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Kayit(ForumSoru f)
        {
            if (ModelState.IsValid)
            {
                string bil = HttpContext.Session.GetString("isUserLogin");
                f.kullanici = c.Kullanicis.Where(x => x.kullanıcıAd.Contains(bil)).FirstOrDefault();
                c.ForumSorus.Add(f);
                c.SaveChanges();
                return RedirectToAction("Detail", f.Id);
            }
            else
            {
                return RedirectToAction("Kayit");
            }
        }
    }

}

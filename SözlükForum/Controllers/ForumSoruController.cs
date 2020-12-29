using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SözlükForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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
    }
}

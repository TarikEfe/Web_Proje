using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
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
            if (ModelState.IsValid)
            {
                c.Kullanicis.Add(k);
                c.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("YeniKullanici");
            }
        }
        
        public async Task<IActionResult> GirisYap(Kullanici k)
        {
            var bilgi = c.Kullanicis.FirstOrDefault(x => x.kullanıcıAd == k.kullanıcıAd && x.sifre == k.sifre);
            if (bilgi != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, k.kullanıcıAd)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("index", "Home");
            }
            return View();
        }
    }
}

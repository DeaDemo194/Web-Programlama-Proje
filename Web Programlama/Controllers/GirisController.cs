using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Programlama.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Web_Programlama.Controllers
{
    public class GirisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YonlendirmeIslemi(string hedef)
        {
            if (hedef == "Admin")
            {
                return RedirectToAction("AdminSayfa");
            }
            else if (hedef == "Kullanici")
            {
                return RedirectToAction("KullaniciSayfa");
            }
            else
            {
                return RedirectToAction("Index"); // Varsayılan olarak ana sayfaya yönlendir
            }
        }

        public IActionResult AdminSayfa()
        {
            return RedirectToAction("Login", "Access");
        }

        public IActionResult KullaniciSayfa()
        {
            return RedirectToAction("Login", "KullaniciGiris");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Programlama.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;


namespace Web_Programlama.Controllers
{
    public class KullaniciGirisController : Controller
    {


        
        public IActionResult Index()
        {
            return View();
        }


      
    }
}

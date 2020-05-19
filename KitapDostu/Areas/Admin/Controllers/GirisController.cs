using KitapDostu.DAL;
using KitapDostu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KitapDostu.Areas.Admin.Controllers
{  [AllowAnonymous]
    public class GirisController : Controller
    {
        // GET: Admin/Giris
        KitapContext ctx = new KitapContext();

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            var kul = ctx.Kullanicilar.FirstOrDefault(x => x.Ad == kullanici.Ad && x.Sifre == kullanici.Sifre);
            if (kul != null)
            {
                FormsAuthentication.SetAuthCookie(kul.Ad, false);
                return RedirectToAction("Index", "Kitap");
            }
            else
            {
                return View("Index", "Kitap");
               
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return View("Login");
        }
    }
}
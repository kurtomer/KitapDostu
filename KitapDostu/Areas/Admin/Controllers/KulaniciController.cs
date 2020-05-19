using KitapDostu.DAL;
using KitapDostu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitapDostu.Areas.Admin.Controllers
{
    public class KulaniciController : Controller
    {
        // GET: Admin/Kulanici
        KitapContext ctx = new KitapContext();
        public ActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(Kullanici klc)
        {
            if (ModelState.IsValid)
            {
                ctx.Kullanicilar.Add(klc);
            }

            int sonuc = ctx.SaveChanges();
            if (sonuc > 0)
            {
                return RedirectToAction("Login", "Giris");
            }
            return View();
        }
    }
}
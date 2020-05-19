using KitapDostu.DAL;
using KitapDostu.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitapDostu.Areas.Admin.Controllers
{
    public class OkuyanController : Controller
    {
        KitapContext ctx = new KitapContext();
        // GET: Admin/Kitap
        public ActionResult Index()

        {

            var okuyanlar = ctx.Okuyanlar.ToList();
            return View(okuyanlar);



        }

        public ActionResult OkuyanEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult OkuyanEkle(Okuyan oky)
        {

            if (ModelState.IsValid)
            {
                ctx.Okuyanlar.Add(oky);
            }

            int sonuc = ctx.SaveChanges();
            if (sonuc > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult OkuyanGuncelle(int? id, Okuyan o)
        {

            var oky = ctx.Okuyanlar.Find(id);

            if (ModelState.IsValid)
            {
                ctx.Okuyanlar.Add(o);
            }
            return View(oky);
        }
        [HttpPost]
        public ActionResult OkuyanGuncelle(Okuyan oky)
        {
            ctx.Entry(oky).State = EntityState.Modified;
            int sonuc = ctx.SaveChanges();
            if (sonuc > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult OkuyanSil(int? id)
        {

            var oky = ctx.Okuyanlar.Find(id);
            ctx.Okuyanlar.Remove(oky);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
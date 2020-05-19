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
    public class KitapController : Controller
        
    {
        KitapContext ctx = new KitapContext();
        // GET: Admin/Kitap
        public ActionResult Index()

        {  
            
                var kitaplar = ctx.Kitaplar.ToList();
                return View(kitaplar);

            
           
        }

        public ActionResult KitapEkle()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult KitapEkle(Kitap ktp)
        {

            if (ModelState.IsValid)
            {
                ctx.Kitaplar.Add(ktp);
           

            int sonuc = ctx.SaveChanges();
            if (sonuc > 0)
            {
                return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult KitapGuncelle(int? id, Kitap ktp)
        {

            var kitap = ctx.Kitaplar.Find(id);

            if (ModelState.IsValid)
            {
                ctx.Kitaplar.Add(ktp);
            }
            return View(kitap);
        }
        [HttpPost]
        public ActionResult KitapGuncelle(Kitap ktp)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(ktp).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public ActionResult KitapSil(int? id)
        {

            var ktp = ctx.Kitaplar.Find(id);
            ctx.Kitaplar.Remove(ktp);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
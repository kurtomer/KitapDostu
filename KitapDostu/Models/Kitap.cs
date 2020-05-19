using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KitapDostu.Models
{
    public class Kitap
    {
        public int Kitapid { get; set; }
        [Required]
        [Display(Name ="Kitap Adı")]
        public string KitapAdi { get; set; }
        [Required]
        [Display(Name = "Sayfa Numarası")]
        public int Sayfa { get; set; }
        [Required]
        [Display(Name = "Yazar Adı")]
        public string Yazar { get; set; }
    }
}
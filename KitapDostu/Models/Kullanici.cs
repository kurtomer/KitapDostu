using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KitapDostu.Models
{
    public class Kullanici
    {
        public int id { get; set; }
        [Display(Name ="Kullanıcı Adı")]
        [Required]
        public  string Ad { get; set; }
        [Display(Name = "Sifre")]
        [Required]
        public string Sifre { get; set; }
    }
}
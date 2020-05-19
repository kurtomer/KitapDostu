using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KitapDostu.Models
{
    public class Okuyan
    {
        public int Okuyanid { get; set; }
        [Required]
        [Display(Name ="Adı")]
        public string OkuyanAd { get; set; }
        [Required]
        [Display(Name = "Soyadı")]
        public string  OkuyanSoyad { get; set; }

    }
}
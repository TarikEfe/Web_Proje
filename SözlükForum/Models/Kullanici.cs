using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SözlükForum.Models
{
    public class Kullanici
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Boş Bırakamazsınız...")]
        [Column(TypeName = "Varchar(20)")]
        [Remote("YeniKullanici", "Kullanici", ErrorMessage = "Email already exists!")]
        public string kullanıcıAd { get; set; }

        [DataType(DataType.Password)]
        [Column(TypeName = "Varchar(10)")]
        [Required(ErrorMessage = "Boş Bırakamazsınız...")]
        public string sifre { get; set; }
        [Required(ErrorMessage = "Boş Bırakamazsınız...")]
        [EmailAddress]
        public string email { get; set; }

        public List<ForumSoru> forumSorus { get; set; }
        public List<Yorum> yorums { get; set; }

    }
}

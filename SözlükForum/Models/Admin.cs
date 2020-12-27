using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SözlükForum.Models
{
    public class Admin
    {
        [Key]
        public int id { get; set; }

        [EmailAddress]
        public string email { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string sifre { get; set; }

        [Column(TypeName = "Varchar(30)")]
        public string kullaniciAdi { get; set; }
    }
}

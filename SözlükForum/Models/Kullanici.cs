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
        [Column(TypeName = "Varchar(20)")]
        public string kullanıcıAd { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string sifre { get; set; }
        [EmailAddress]
        public string email { get; set; }

    }
}

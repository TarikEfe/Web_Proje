using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SözlükForum.Models
{
    public class Kullanıcı
    {
        public int id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string password { get; set; }
    }
}

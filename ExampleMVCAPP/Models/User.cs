using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExampleMVCAPP.Models
{
    [Table("User", Schema = "public")]

    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
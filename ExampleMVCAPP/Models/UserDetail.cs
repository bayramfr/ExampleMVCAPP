using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExampleMVCAPP.Models
{
    [Table("UserDetail", Schema = "public")]

    public class UserDetail
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public int f_user_id { get; set; }
    }
}
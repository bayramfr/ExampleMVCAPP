using ExampleMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleMVCAPP.DataContext
{
    public class DBContext:DbContext
    {
        public DBContext() : base(nameOrConnectionString: "myConnectionString")
        {
        }
        public virtual DbSet<User> UserSet { get; set; }
        public virtual DbSet<UserDetail> UserDetailSet { get; set; }
    }
}
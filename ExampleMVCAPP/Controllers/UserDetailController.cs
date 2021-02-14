using ExampleMVCAPP.DataContext;
using ExampleMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVCAPP.Controllers
{
    public class UserDetailController : Controller
    {
        // GET: UserDetail
        DBContext dbObj = new DBContext();
        static int userId;
        public ActionResult UserDetail(int id)
        {
            userId = id;
            using (dbObj)
            {
                return View(dbObj.UserDetailSet.Where(x => x.f_user_id == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult UserDetail(UserDetail userDetailObj)
        {
            var availUser = dbObj.UserDetailSet.Where(x => x.f_user_id == userId).FirstOrDefault();
            if (availUser != null)
            {
                availUser.Name = userDetailObj.Name;
                availUser.Surname = userDetailObj.Surname;
                availUser.Email = userDetailObj.Email;
         
            }
            else 
            {
                userDetailObj.f_user_id = userId;
                dbObj.UserDetailSet.Add(userDetailObj);
                dbObj.SaveChanges();              
              
            }
            dbObj.SaveChanges();

            return View(dbObj.UserDetailSet.Where(x => x.f_user_id == userId).FirstOrDefault());
        }
    }
}
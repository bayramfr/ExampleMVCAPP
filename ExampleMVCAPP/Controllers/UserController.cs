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
    public class UserController : Controller
    {
        // GET: User

        DBContext dbObj = new DBContext();
    
        public ActionResult UserView()
        {
            return View(dbObj.UserSet.ToList());
        }

        public ActionResult AddUser()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User userObj)
        {
            dbObj.UserSet.Add(userObj);
            dbObj.SaveChanges();
            return View("UserView", dbObj.UserSet.ToList());
        }
        public ActionResult EditUser(int id)
        {
            using (dbObj)
            {
                return View(dbObj.UserSet.Where(x => x.ID == id).FirstOrDefault());
            }

        }
        [HttpPost]
        public ActionResult EditUser(User userObj)
        {
            dbObj.Entry(userObj).State = EntityState.Modified;
            dbObj.SaveChanges();

            return View("UserView", dbObj.UserSet.ToList());
        }
        public ActionResult DeleteUser(int id)
        {
            var availUser = dbObj.UserSet.Find(id);
            if (availUser != null)
            {
                dbObj.UserSet.Remove(availUser);
            }
            dbObj.SaveChanges();
            return View("UserView", dbObj.UserSet.ToList());
        }
    }
}
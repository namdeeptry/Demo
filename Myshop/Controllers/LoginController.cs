using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        // khai báo db
        shoeEntities s = new shoeEntities();
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(string uname,string psw)
        {
            // check điều kiện
            int countz = s.users.Count(m => m.username.ToLower() == uname.ToLower() && m.password.ToLower() == psw.ToLower());
            if(countz ==1 )
            {
                //tạo session giá trị 
                Session["user"] = uname;
                ViewBag.user = uname;
            }    
            else
            {
                TempData["error"] = "Please check your user or password again ";
                 return View();
            }
            return RedirectToAction("home","Home");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult product()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Laptop()
        {
            
            return View();
        }

        
        public ActionResult Travel()
        {

            return View();
        }

       
        public ActionResult Camera()
        {
            return View();
        }

        
        public ActionResult Bags()
        {
            return View();
        }

        
        public ActionResult Accessories()
        {
            return View();
        }
    }
}
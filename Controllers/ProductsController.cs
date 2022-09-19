using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFirstMVC.Models;

namespace WebAppFirstMVC.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindOriginalEntities db = new NorthwindOriginalEntities();

        // GET: Products
        public ActionResult Index()
        {

            if (Session["UserName"] == null)
            {
                return RedirectToAction("login", "home");
            }
            else
            {
                NorthwindOriginalEntities db = new NorthwindOriginalEntities();
                List<Products> model = db.Products.ToList();
                db.Dispose();
                return View(model);
            }
        }
    }
}
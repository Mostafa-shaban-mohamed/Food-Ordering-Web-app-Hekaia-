using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Restaurant_Website.Models;

namespace Restaurant_Website.Controllers
{
    public class FoodsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private FoodOrderingDBEntities dbo = new FoodOrderingDBEntities();

        [Authorize]
        // GET: Foods
        public ActionResult Index()
        {
            return View(dbo.Foods.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

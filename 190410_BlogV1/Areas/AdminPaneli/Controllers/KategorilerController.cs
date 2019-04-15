using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _190410_BlogV1.Areas.AdminPaneli.Controllers
{
    public class KategorilerController : Controller
    {
        Models.Bloghi304DBEntities db = new Models.Bloghi304DBEntities();
        // GET: AdminPaneli/Kategoriler
        public ActionResult KategoriListesiIndex()
        {
            return View(db.Kategoriler.ToList());
        }
    }
}
using QLSinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLSinhVien.Controllers
{
    public class QLSinhVienController : Controller
    {
        // GET: QLSinhVien

        CNPMEntities DB = new CNPMEntities();
        public ActionResult Index()
        {
            var All_DuLieu = from tt in DB.QLSinhViens select tt;
            return View(All_DuLieu);
        }
    }
}   
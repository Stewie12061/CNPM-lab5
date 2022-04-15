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
            return View(DB.QLSinhVienns.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(QLSinhVienn qlsv)
        {
            try
            {
                DB.QLSinhVienns.Add(qlsv);
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("Error Create New");
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(DB.QLSinhVienns.Where(s => s.id == id).FirstOrDefault());
        }

        public ActionResult Edit(int id)
        {
            return View(DB.QLSinhVienns.Where(s => s.id == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(int id, QLSinhVienn qlsv)
        {
            DB.Entry(qlsv).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(DB.QLSinhVienns.Where(s => s.id == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int id, QLSinhVienn qlsv)
        {
            try
            {
                qlsv = DB.QLSinhVienns.Where(s => s.id == id).FirstOrDefault();
                DB.QLSinhVienns.Remove(qlsv);
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("This data is using in other table, Error Delete!");
            }
        }
    }

    
}   
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager cm = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = cm.GetList();
            return View(adminvalues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            cm.AdminAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public ActionResult EditAdmin(int id)
        {
            var value = cm.GetByID(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            cm.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
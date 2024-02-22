using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }
        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "Yazılım",
                Count = 8
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Seyahat",
                Count = 4
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Teknoloji",
                Count = 7
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                Count = 1
            });
            return ct;

        }
    }
}
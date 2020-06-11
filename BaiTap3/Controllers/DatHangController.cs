using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap3.Controllers
{
    public class DatHangController : Controller
    {
        // GET: DatHang
        public ActionResult Index()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            ViewBag.List = new SelectList(new[]
            {
                new { ID="Volvo", Name="Volvo" },
                new { ID="BMW", Name="BMW" },
                new { ID="Ford", Name="Ford" },
            }, "ID", "Name", 1);
            return View();
        }
        public ActionResult ThemSP()
        {

        }

    }
}
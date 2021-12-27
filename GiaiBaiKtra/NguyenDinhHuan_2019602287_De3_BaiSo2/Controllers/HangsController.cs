using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NguyenDinhHuan_2019602287_De3.Models;

namespace NguyenDinhHuan_2019602287_De3.Controllers
{
    public class HangsController : Controller
    {
        private NguyenDinhHuan db = new NguyenDinhHuan();

        // GET: Hangs
        public ActionResult Index(string start, string end) 
        {
            int s = 0;
            if (!string.IsNullOrEmpty(start) && !string.IsNullOrEmpty(end))
            {
                ViewBag.CurrentFilter = start;
                ViewBag.CurrentFilter2 = end;
                var hangs2 = db.Hangs.ToList().Where(h => h.Gia >= int.Parse(start) && h.Gia <= int.Parse(end)).ToList();
                foreach(Hang hang in hangs2)
                {
                    s += (int)hang.Gia;
                }
                ViewBag.Tong = s;
                return View(hangs2);
            }

            foreach (Hang hang in db.Hangs.ToList())
            {
                s += (int)hang.Gia;
            }
            ViewBag.Tong = s;
            return View(db.Hangs.ToList());

        }


    }
}

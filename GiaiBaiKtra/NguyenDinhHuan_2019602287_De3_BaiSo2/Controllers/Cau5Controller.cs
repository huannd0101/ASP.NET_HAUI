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
    public class Cau5Controller : Controller
    {
        private NguyenDinhHuan db = new NguyenDinhHuan();


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Mahang,Tenhang,Loai,Gia")] Hang hang)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Hangs.Add(hang);
                    db.SaveChanges();
                    ViewBag.Success = "Thêm thành công";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu!" + ex.Message;
                return View(hang);
            }
            

            return View(hang);
        }



    }
}

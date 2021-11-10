using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDinhHuan_2019602287_De3.Models;

namespace NguyenDinhHuan_2019602287_De3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cau1()
        {
            return View();
        }

        public ActionResult Cau2()
        {
            return View();
        }

        public ActionResult KetQua(NhanVien nv)
        {
            if(nv.SoNgay >= 25)
            {
                nv.ThuNhap = (nv.LuongNgay * nv.SoNgay) + 500000;
            }else
            {
                nv.ThuNhap = (nv.LuongNgay * nv.SoNgay);
            }
            return View(nv);
        }
    }
}
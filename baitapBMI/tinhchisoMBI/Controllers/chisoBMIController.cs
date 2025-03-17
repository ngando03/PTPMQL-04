using Microsoft.AspNetCore.Mvc;
using System;
using tinhchisoMBI.Models;

namespace tinhchisoMBI.Controllers
{
    public class chisoBMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string ten, string tuoi, double chieucao, double cannang, int diemA, int diemB, int diemC, string donhang1, string donhang2, string donhang3)
        {
            var BMI = cannang / ((chieucao / 100) * (chieucao / 100));
            var DMH = (diemA * 0.6) + (diemB * 0.3) + (diemC * 0.1);
            var tongtien = (donhang1)+(donhang2)+(donhang3);
            ViewBag.BMI = BMI;
            ViewBag.dmh = DMH;
            ViewBag.Tongtien =tongtien; 
            ViewBag.ten = ten;
            ViewBag.tuoi = tuoi;
            

            return View();
        }
        
    }
}

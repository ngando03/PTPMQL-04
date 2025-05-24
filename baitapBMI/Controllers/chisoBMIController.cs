using Microsoft.AspNetCore.Mvc;
using tinhchisoMBI.Models;
using System;
using System.IO;
using System.Linq;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore;
using tinhchisoMBI.Data;

namespace tinhchisoMBI.Controllers
{
    public class chisoBMIController : Controller
    {
        private readonly ApplicationDbcontext _context;

        public chisoBMIController(ApplicationDbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(new chisoBMI());
        }

        [HttpPost]
        public IActionResult Index(chisoBMI model)
        {
            if (model.Action == "Tính BMI")
            {
                model.BMI = model.CanNang / Math.Pow((model.ChieuCao / 100), 2);
            }
            else if (model.Action == "Tính điểm")
            {
                model.DiemTong = (model.DiemA * 0.6) + (model.DiemB * 0.3) + (model.DiemC * 0.1);
            }
            else if (model.Action == "Tính tổng tiền")
            {
                double.TryParse(model.DonHang1, out double d1);
                double.TryParse(model.DonHang2, out double d2);
                double.TryParse(model.DonHang3, out double d3);
                model.TongTien = d1 + d2 + d3;
            }

            // ✅ Lưu vào DB
            _context.Person.Add(model);
            _context.SaveChanges();

            return View(model);
        }


        [HttpGet]
        public IActionResult Download()
        {
            var fileName = $"DanhSach_chisoBMI_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");

                worksheet.Cells["A1"].Value = "Tên";
                worksheet.Cells["B1"].Value = "Tuổi";
                worksheet.Cells["C1"].Value = "Chiều cao";
                worksheet.Cells["D1"].Value = "Cân nặng";
                worksheet.Cells["E1"].Value = "BMI";
                worksheet.Cells["F1"].Value = "Điểm tổng";
                worksheet.Cells["G1"].Value = "Tổng tiền";

                var personList = _context.Person.ToList();

                worksheet.Cells["A2"].LoadFromCollection(personList.Select(p => new
                {
                    p.Ten,
                    p.Tuoi,
                    p.ChieuCao,
                    p.CanNang,
                    p.BMI,
                    p.DiemTong,
                    p.TongTien
                }), false);

                var stream = new MemoryStream(excelPackage.GetAsByteArray());

                return File(stream,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    fileName);
            }
        }
    }
}

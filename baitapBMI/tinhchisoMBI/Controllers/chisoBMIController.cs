using Microsoft.AspNetCore.Mvc;
using tinhchisoMBI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using tinhchisoMBI.Data;
using OfficeOpenXml;

namespace tinhchisoMBI.Controllers
{
    public class chisoBMIController : Controller
    {
        private ApplicationDbcontext _context;
        public chisoBMIController(ApplicationDbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(new Person());
        }

        private ExcelProcess _excelProcess = new ExcelProcess();

        [HttpPost]
        public IActionResult Index(Person model)
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

            return View(model);
        }
        // POST: /Excel/Upload
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file)
    {
        if (file != null)
        {
            string fileExtension = Path.GetExtension(file.FileName).ToLower();

            if (fileExtension != ".xlsx" && fileExtension != ".xls")
            {
                ModelState.AddModelError("", "Please upload a valid Excel file.");
            }
            else
            {
                // Tạo thư mục lưu file
                var fileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + fileExtension;
                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", "Excels");
                Directory.CreateDirectory(uploadPath);

                var filePath = Path.Combine(uploadPath, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Đọc file Excel thành DataTable
                DataTable dt = _excelProcess.ExcelToDataTable(filePath);

                // Duyệt từng dòng để thêm vào DB
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var ps = new Person
                    {
                        Ten = dt.Rows[i][0].ToString(),
                        Tuoi = Convert.ToInt32(dt.Rows[i][1]),
                        ChieuCao = Convert.ToDouble(dt.Rows[i][2]),
                        CanNang = Convert.ToDouble(dt.Rows[i][3]),
                        DiemA = Convert.ToInt32(dt.Rows[i][4]),
                        DiemB = Convert.ToInt32(dt.Rows[i][5]),
                        DiemC = Convert.ToInt32(dt.Rows[i][6]),
                        DonHang1 = dt.Rows[i][7].ToString(),
                        DonHang2 = dt.Rows[i][8].ToString(),
                        DonHang3 = dt.Rows[i][9].ToString()
                    };
                    _context.Add(ps);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                }
            }

             return View();
        }
       public IActionResult Download()
{
    // Đường dẫn tới file template
    var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", "d.xlsx");

    if (!System.IO.File.Exists(templatePath))
    {
        return NotFound("Template Excel không tồn tại.");
    }

    // FIXED license
    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

    // Load file template
    using (var stream = new FileStream(templatePath, FileMode.Open, FileAccess.Read))
    using (var package = new ExcelPackage(stream))
    {
        var worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên

        // Lấy dữ liệu từ DB
        var people = _context.Person.Select(p => new
        {
            p.Ten,
            p.Tuoi,
            p.ChieuCao
        }).ToList();

        // Ghi dữ liệu vào từ dòng 2, cột A
        int startRow = 2;
        for (int i = 0; i < people.Count; i++)
        {
            worksheet.Cells[startRow + i, 1].Value = people[i].Ten;
            worksheet.Cells[startRow + i, 2].Value = people[i].Tuoi;
            worksheet.Cells[startRow + i, 3].Value = people[i].ChieuCao;
        }

        worksheet.Cells.AutoFitColumns();

        // Trả file đã fill về client
        var resultBytes = package.GetAsByteArray();

        return File(resultBytes,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "DanhSach_Filled.xlsx");
    }
}


    }
}

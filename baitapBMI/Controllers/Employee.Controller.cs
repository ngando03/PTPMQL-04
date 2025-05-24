using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;

namespace tinhchisoMBI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Debug.txt");

                if (!System.IO.File.Exists(path))
                {
                    System.IO.File.WriteAllText(path, $"[TẠO FILE] {DateTime.Now}\n");
                }
                else
                {
                    System.IO.File.AppendAllText(path, $"[GHI LOG] {DateTime.Now}\n");
                }

                ViewBag.FilePath = path;
                ViewBag.Content = System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                ViewBag.FilePath = "LỖI: " + ex.Message;
            }

            return View();
        }
    }
}

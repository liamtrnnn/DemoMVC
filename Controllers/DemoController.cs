using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delete()
        {
            // Giả lập xóa sản phẩm

            TempData["ThongBao"] = "Xóa sản phẩm thành công!";

            return RedirectToAction("Index");
        }
    }
}
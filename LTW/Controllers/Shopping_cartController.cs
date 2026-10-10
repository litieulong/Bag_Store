using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW.Controllers
{
    public class Shopping_cartController : Controller
    {
        // GET: Shopping_cart
            // 1. Hiển thị trang Giỏ hàng (Giao diện 2 cột bạn vừa tạo)
            public ActionResult Index() // Hoặc Shop() tùy theo tên bạn thiết lập
            {
                return View("Shop"); // Hoặc return View(); nếu đổi tên file thành Index.cshtml
            }

            // 2. Hiển thị trang Thanh toán (Checkout)
            public ActionResult Checkout()
            {
                return View(); // Trỏ đến file Checkout.cshtml trong thư mục Views/Shopping_cart/
            }

            // 3. Xử lý khi người dùng bấm nút đặt hàng ở trang thanh toán
            [HttpPost]
            public ActionResult ProcessCheckout(string FullName, string Phone, string Address, string PaymentMethod)
            {
                // Xử lý lưu đơn hàng vào Database tại đây...

                // Sau khi đặt hàng thành công, có thể chuyển hướng đến trang xác nhận (Confirm.cshtml)
                return RedirectToAction("Confirm");
            }

            // 4. Trang xác nhận đơn hàng thành công
            public ActionResult Confirm()
            {
                return View(); // Trỏ đến file Confirm.cshtml
            }
    }
}
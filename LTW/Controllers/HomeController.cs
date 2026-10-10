using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW.Controllers
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
        public ActionResult ChiTiet(int id = 1)
        {
            // Dữ liệu mẫu tĩnh trong C# (hoặc bạn có thể truy vấn từ Database)
            if (id == 2)
            {
                ViewBag.Code = "BL-DULICH-02";
                ViewBag.Name = "Balo Du Lịch Phượt Dung Tích 40L";
                ViewBag.Price = "850.000 đ";
                ViewBag.Desc = "Dung tích lớn 40L phù hợp đi phượt từ 3-5 ngày. Tích hợp đai trợ lực lưng hông giúp giảm tải trọng khi mang nặng.";
                ViewBag.Img = "https://down-vn.img.susercontent.com/file/vn-11134207-81ztc-mqfq251oeole40";
            }
            else if (id == 3)
            {
                ViewBag.Code = "TUI-CHEO-03";
                ViewBag.Name = "Túi Đeo Chéo Thể Thao Nam";
                ViewBag.Price = "290.000 đ";
                ViewBag.Desc = "Thiết kế thể thao năng động, nhỏ gọn đựng vừa iPad 11 inch và đồ dùng cá nhân khi đi dạo phố, thể thao.";
                ViewBag.Img = "https://bizweb.dktcdn.net/100/044/266/files/tui-dung-giay-the-thao-hier-sportwear-15.jpg?v=1720445119204";
            }
            else // Mặc định là sản phẩm 1
            {
                ViewBag.Code = "BL-LAPTOP-01";
                ViewBag.Name = "Balo Laptop Chống Nước Premium";
                ViewBag.Price = "550.000 đ";
                ViewBag.Desc = "Balo chuyên dụng đựng Laptop 15.6 inch, chất liệu vải Polyester chống nước tuyệt đối, có ngăn chống sốc 3D bảo vệ thiết bị an toàn.";
                ViewBag.Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGb44tx25RPitIKUEfVE2FfHvgs-ybhZ0vwcCzquctFwQ2BuQiGaWyIqlk&s=10";
            }

            return View();
        }
    }
}
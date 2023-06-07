using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _411018890.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Music()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Music(String name, String num)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                ViewBag.NameMsg = "請輸入姓名";
            }
            if (String.IsNullOrWhiteSpace(num))
            {
                ViewBag.numMsg = "請輸入數字";
            }
            if (!(String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(num)))
            {
                var mm = "";
                switch (num)
                {
                    case "1":
                        mm = "do";
                        break;
                    case "2":
                        mm = "re";
                        break;
                    case "3":
                        mm = "mi";
                        break;
                    case "4":
                        mm = "fa";
                        break;
                    case "5":
                        mm = "so";
                        break;
                    case "6":
                        mm = "la";
                        break;
                    case "7":
                        mm = "xi";
                        break;
                    default:
                        mm = "錯誤";
                        break;
                }
                ViewBag.Msg = "Hi,"+name+", 查詢音符為:"+mm;
            }
            return View();
        }
    }
}
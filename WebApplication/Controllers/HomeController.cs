using GlobalResources;
using GlobalResources.Web.Controllers;
using System;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = HomeResource.AboutMsg;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = HomeResource.ContactMsg;

            return View();
        }

        /// <summary>
        /// 切換語系
        /// </summary>
        /// <param name="lang">語系</param>
        /// <returns></returns>
        public JsonResult SwitchLanguage(string lang)
        {
            try
            {
                // 驗證語系是否存在
                lang = CultureHelper.GetImplementedCulture(lang);

                // 語系設定至Cookie
                HttpCookie cookie = Request.Cookies["Lang"];

                if (cookie != null)
                {
                    // 更新 Cookie
                    cookie.Value = lang;
                }
                else
                {
                    // 建立 Cookie
                    cookie = new HttpCookie("Lang");
                    cookie.Value = lang;
                    cookie.Expires = DateTime.Now.AddYears(1);
                }
                Response.Cookies.Add(cookie);

                return Json("success");
            }
            catch (Exception)
            {
                return Json("fail");
            }
        }
    }
}
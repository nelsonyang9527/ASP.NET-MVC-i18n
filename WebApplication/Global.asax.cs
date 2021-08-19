using GlobalResources;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            HttpCookie cultureCookie = Request.Cookies["Lang"];
            // 取得語系檔名稱，若Cookies無設定，預設抓用戶瀏覽器語系
            var cultureInfoName = CultureHelper.GetImplementedCulture((cultureCookie == null) ? Request.UserLanguages[0] : cultureCookie.Value);
            // 設定語系
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureInfoName);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureInfoName);
        }
    }
}

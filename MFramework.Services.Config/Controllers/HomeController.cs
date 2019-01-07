using System.Web.Mvc;

namespace MFramework.Services.Config.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.AppSettingsEmailHostValue = ConfigServiceWrapper.ConfigService.GetAppSettingsValue<string>(ConfigKeys.AppSetting_EMailHost);
            ViewBag.ConnStrDefaultConnStrValue = ConfigServiceWrapper.ConfigService.GetConnectionString(ConfigKeys.ConnStr_DefaultConnStrName);
            return View();
        }
    }
}
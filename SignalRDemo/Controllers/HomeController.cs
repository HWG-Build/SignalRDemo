using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Referral()
        {
            return View("Referral");
        }
    }
}
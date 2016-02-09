using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Referral()
        {
            return View("Referral");
        }

        [Authorize]
        public ActionResult AuthorizeEchoHub()
        {
            ViewBag.Message = "Only an authenticated user can connect to this Hub.";

            return View();
        }
    }
}
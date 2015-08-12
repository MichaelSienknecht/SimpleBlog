using SimpleBlog.Infrastructure;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin")]
    
    public class UsersController : Controller
    {
       
        public ActionResult Index()
        {
            ViewBag.SelectedTab = "users";
            return View();
        }
    }
}
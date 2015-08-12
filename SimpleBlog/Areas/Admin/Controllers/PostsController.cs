using SimpleBlog.Infrastructure;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        [Authorize(Roles ="admin")]
       
        public ActionResult Index()
        {
            ViewBag.SelectedTab = "posts";
            return View();
        }
    }
}
using BeBetter.Models;
using System.Web.Mvc;

namespace BeBetter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var articles = db.Articles;
                return View(db.Articles);
            }
        }
    }
}
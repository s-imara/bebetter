using BeBetter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeBetter.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<ArticleModel> art = db.Articles.ToList();
                return View(art);
            }
        }

        public ActionResult Add(String title, String body)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var art = new ArticleModel();
                art.Title = title;
                art.Body = body;
                db.Articles.Add(art);
                db.SaveChanges();
                var article = db.Articles.ToList();
                return View("Index",article);
            }
        }
        public ActionResult AddOrEditArticle()
        {
            return View("AddOrEditArticle");
        }
    }
}
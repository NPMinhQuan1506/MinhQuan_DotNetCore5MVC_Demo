using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhQuan_DotNetCoreMVC5_Demo.Controllers
{
    public class CustomController : Controller
    {

        /*
        // GET: CustomController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */

        public IActionResult Index()
        {
            var articles = new List<Article>()
            {
                new Article {Id = 1, Title = "title1", Content = "content1", Author = "Quan"},
                new Article {Id = 2, Title = "title2", Content = "content2", Author = "Haha"},
                new Article {Id = 3, Title = "title3", Content = "content3", Author = "Quan"},
                new Article {Id = 4, Title = "title4", Content = "content4", Author = "Nguyet"},
                new Article {Id = 5, Title = "title5", Content = "content5", Author = "Quan"},
                new Article {Id = 6, Title = "title6", Content = "content6", Author = "Nguyet"},
                new Article {Id = 7, Title = "title7", Content = "content7", Author = "Quan"},
                new Article {Id = 8, Title = "title8", Content = "content8", Author = "Nguyet"},
                new Article {Id = 9, Title = "title9", Content = "content9", Author = "Quan"},

            };
            //Option 1: ViewBag return dynamic object
            //ViewBag.Articles = articles;
            //Option 2: ViewData return Dictionary so we must cast type of it
            //ViewData["Articles"] = articles;
            //Option 3: DataModel

            //When pass data has big size, we should use DataModel, and vice versa, we use option 1 and 2
            return View(articles);
        }

        public string StringOut(string id, Employee emp)
        {
            return $"This is id {id}. First Name {emp.firstname}. Last Name {emp.lastname} ";
        }

        //public ActionResult actionResult(string id, Employee emp)
        //{
        //    return Content($"This is action result {id}. First Name {emp.firstname}. Last Name {emp.lastname} ");
        //}

        //public JsonResult ActionJSON(string id, Employee emp)
        //{
        //    var obj = new { Id = id, emp = emp };
        //    return Json(obj);
        //}

        public IActionResult actionResult(string id, Employee emp)
        {
            return Content($"This is action result {id}. First Name {emp.firstname}. Last Name {emp.lastname} ");
        }

        public IActionResult ActionJSON(string id, Employee emp)
        {
            var obj = new { Id = id, emp = emp };
            return Json(obj);
        }
    }

    public class Employee
    {
        public string firstname { get; set; }

        public string lastname { get; set; }
    }

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}

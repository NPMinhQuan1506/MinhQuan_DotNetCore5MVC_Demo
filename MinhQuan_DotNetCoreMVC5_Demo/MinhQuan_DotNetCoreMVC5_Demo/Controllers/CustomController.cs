using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return View();
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
}

using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        // GET: HomeController1
        public ActionResult Menu()
        {
            List<Pizza> pizze;

            using (PizzaContext db = new PizzaContext())
            {
                pizze = db.Pizzas.ToList();
            }

            ViewData["Title"] = "Menu";

            return View(pizze);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {

            Pizza pizzaCurrent;

            using (PizzaContext db = new PizzaContext())
            {
                pizzaCurrent = db.Pizzas.Where(p => p.Id == id).FirstOrDefault();
            }

            if(pizzaCurrent == null)
            {
                ViewData["Title"] = "Error404";
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return View("Error404");
            }
            else
            {
                ViewData["Title"] = pizzaCurrent.Name;
                return View(pizzaCurrent);
            }

        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
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

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
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

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
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
    }
}

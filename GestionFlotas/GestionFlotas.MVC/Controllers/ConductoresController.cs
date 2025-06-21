using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionFlotas; // Asegúrarse de usar el using correcto
using System.Collections.Generic;


namespace GestionFlotas.MVC.Controllers
{
    public class ConductoresController : Controller
    {
        // GET: ConductoresController
        public ActionResult Index()
        {
            var listaVacia = new List<Conductor>();
            return View(listaVacia);
        }

        // GET: ConductoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConductoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConductoresController/Create
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

        // GET: ConductoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConductoresController/Edit/5
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

        // GET: ConductoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConductoresController/Delete/5
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

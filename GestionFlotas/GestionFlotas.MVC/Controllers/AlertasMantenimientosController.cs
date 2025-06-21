using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionFlotas; // Asegúrarse de usar el using correcto
using System.Collections.Generic;


namespace GestionFlotas.MVC.Controllers
{
    public class AlertasMantenimientosController : Controller
    {
        // GET: AlertasMantenimientosController
        public ActionResult Index()
        {
            var listaVacia = new List<AlertaMantenimiento>();
            return View(listaVacia);
        }

        // GET: AlertasMantenimientosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlertasMantenimientosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlertasMantenimientosController/Create
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

        // GET: AlertasMantenimientosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlertasMantenimientosController/Edit/5
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

        // GET: AlertasMantenimientosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlertasMantenimientosController/Delete/5
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

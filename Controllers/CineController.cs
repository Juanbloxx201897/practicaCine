using Microsoft.AspNetCore.Mvc;
using SistemaCine.Models;

namespace SistemaCine.Controllers
{
    public class CineController : Controller
    {
        static List<Cine> listaPeliculas = new List<Cine>();

        public IActionResult Index()
        {
            return View(listaPeliculas);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Cine cine)
        {
            listaPeliculas.Add(cine);

            return RedirectToAction("Index");
        }
    }
}
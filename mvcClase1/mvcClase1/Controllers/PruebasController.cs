using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcClase1.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            ViewBag.nombre = "Geovani de León";
            return View();
        }

        // GET: Pruebas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pruebas/Calcular
        public ActionResult Calcular(int num1,int num2)
        {
            int resultado = num1 + num2;
            ViewBag.resultado = resultado;
            return View();
        }

        public ActionResult HolaMundo() {

            return View();
        }

        
    }
}

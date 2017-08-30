using mvcClase1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcClase1.Controllers
{
    public class FuncionesController : Controller
    {
        List<Personas> lstPersonas = new List<Personas>();
        // GET: Funciones
        public ActionResult Index()
        {
            nuevaPersona("Julio", "Archila");
            nuevaPersona("Carlos", "Muñoz");
            nuevaPersona("Juan", "Pancho");
            ViewBag.personas = lstPersonas;
            return View();
        }


        private void nuevaPersona(string nombres, string apellidos) {
            Personas persona = new Personas();
            persona.nombres = nombres;
            persona.apellidos = apellidos;
            lstPersonas.Add(persona);
        }
    }
}
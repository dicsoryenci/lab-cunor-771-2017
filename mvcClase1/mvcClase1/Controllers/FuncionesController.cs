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
        ctxTestCunor ctx = new ctxTestCunor();

        // GET: Funciones
        public ActionResult Index()
        {
            producto p1 = new producto();

            p1.descripcion = "Tomatiollos";
            p1.cod_proveedor = 1;
            p1.estado_activo = 1;
            p1.fec_caducidad = DateTime.Now;
            p1.fec_creacion = DateTime.Now;
            p1.precio_compra = 2;
            ctx.producto.Add(p1);
            ctx.SaveChanges();


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
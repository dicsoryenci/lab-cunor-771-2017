using mvcClase1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcClase1.Controllers
{
    public class ProductosController : Controller
    {
        ctxTestCunor ctx = new ctxTestCunor();
        // GET: Productos
        public ActionResult Index()
        {
            var productos = from p in ctx.producto
                            select p;

            ViewBag.productos = productos;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(producto p)
        {
           
            p.cod_proveedor = 1;
            p.estado_activo = 1;
            p.fec_caducidad = DateTime.Now;
            p.fec_creacion = DateTime.Now;
            ctx.producto.Add(p);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var producto = (from p in ctx.producto
                            where p.cod_producto == id
                            select p).FirstOrDefault();
            return View(producto);
        }

        [HttpPost]
        public ActionResult Edit(producto p)
        {
            var pEditar = (from p1 in ctx.producto
                            where p1.cod_producto == p.cod_producto
                            select p1).FirstOrDefault();

            pEditar.nom_producto = p.nom_producto;
            pEditar.descripcion = p.descripcion;
            pEditar.precio_compra = p.precio_compra;

            ctx.Entry(pEditar).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var producto = (from p in ctx.producto
                            where p.cod_producto == id
                            select p).FirstOrDefault();

            ctx.Entry(producto).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
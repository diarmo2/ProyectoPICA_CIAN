using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerAzure2.Datos;
using TallerAzure2.Models;

namespace TallerAzure2.Controllers
{
    public class TramiteController : Controller
    {
        TramiteAdmin admin = new TramiteAdmin();
        // GET: Tramite
        public ActionResult Index()
        {
            IEnumerable<Tramite> modelo = admin.Consultar();
            return View(modelo);
        }


        public ActionResult Crear()
        {

            return View();
        }
        public ActionResult Guardar(Tramite modelo)
        {
            admin.Guardar(modelo);
            ViewBag.mensaje ="Trámite Guardado";
            return View("Crear", modelo);
        }

        public ActionResult Editar(int id)
        {
            Tramite modelo = admin.Consultar(id);
            return View(modelo);         
        }

        
        public ActionResult Modificar(Tramite modelo)
        {
            admin.Modificar(modelo);
            ViewBag.mensaje ="Trámite Modificado";
            return View("Editar", modelo);
        }


        public ActionResult Detalle(int id)
        {
            Tramite modelo = admin.Consultar(id);
            return View(modelo);
        }


        public ActionResult Eliminar(int id)
        {
            Tramite modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            IEnumerable<Tramite> lista = admin.Consultar();
            return View("Index", lista);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerEF1.Datos;
using TallerEF1.Models;

namespace TallerEF1.Controllers
{
    public class TramiteController : Controller
    {
        TramiteAdmin admin = new TramiteAdmin();
        // GET: Tramite
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Conultar los datos de AspNetUsers
        /// </summary>
        /// <returns> Vista de Consultar </returns>
        public ActionResult Consultar()
        {
            IEnumerable<Tramite> modelo = admin.Consultar();
            return View(modelo);
        }
    }
}
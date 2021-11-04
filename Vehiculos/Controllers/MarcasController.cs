using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vehiculos.Models;

namespace Vehiculos.Controllers
{
    public class MarcasController : Controller
    {
        // GET: Marcas
        public ActionResult ComboMarcas()
        {
            using (VehiculosDBContainer db = new VehiculosDBContainer())
            {
                return PartialView(db.Marcas.ToList());
            }
        }
    }
}
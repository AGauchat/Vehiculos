using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vehiculos.Models;
using Vehiculos.Models.Views;
using System.Web.Mvc;
using Vehiculos.Controllers.Services;

namespace Vehiculos.Controllers
{
    public class VehiculosController : Controller
    {
        public ActionResult Index()
        {
            using (VehiculosDBContainer db = new VehiculosDBContainer())
            {
                List<VehiculosView> data = (from vehiculo in db.Vehiculos
                                            join marca in db.Marcas on vehiculo.IDMarca equals marca.Id
                                            select new VehiculosView()
                                            {
                                                Id = vehiculo.Id,
                                                IDMarca = vehiculo.IDMarca,
                                                Dueño = vehiculo.Dueño,
                                                Marca = marca.Marca,
                                                Modelo = vehiculo.Modelo,
                                                Patente = vehiculo.Patente,
                                                Puertas = vehiculo.Puertas
                                            }).ToList();
                return View(data);
            }

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Vehiculos vehiculo)
        {
            try
            {
                using (VehiculosDBContainer db = new VehiculosDBContainer())
                {
                    if (!ModelState.IsValid) return View();
                    db.Vehiculos.Add(vehiculo);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GetNombres(int pages)
        {
            try
            {
                List<Data> data = new List<Data>();
                Get<GetResponse> asd = new Get<GetResponse>();
                for (int i = 0; i < pages; i++)
                {
                    GetResponse response = asd.get("https://reqres.in/api/users?page=" + (i + 1).ToString());
                    response.data.ForEach((item) => data.Add(item));
                }

                return PartialView(data);
            }
            catch
            {
                return PartialView(new List<Data>());
            }

        }
    }
}
using NUnit.Framework;
using System.Web.Mvc;
using Vehiculos.Controllers;

namespace Tests.Tests
{
    class VehiculosTests
    {
        [Test]
        public void IndexTest()
        {
            VehiculosController controller = new VehiculosController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateTest()
        {
            VehiculosController controller = new VehiculosController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetNombresTest()
        {
            VehiculosController controller = new VehiculosController();
            PartialViewResult result = controller.GetNombres(3) as PartialViewResult;
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreatePostTest()
        {
            Vehiculos.Models.Vehiculos vehiculo = new Vehiculos.Models.Vehiculos()
            {
                Dueño = "Unit Test",
                IDMarca = 1,
                Modelo = "Audi",
                Patente = "12345678",
                Puertas = 2
            };
            VehiculosController controller = new VehiculosController();
            RedirectToRouteResult result = controller.Create(vehiculo) as RedirectToRouteResult;
            Assert.IsNotNull(result);
        }
    }
}

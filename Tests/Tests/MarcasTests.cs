using NUnit.Framework;
using System.Web.Mvc;
using Vehiculos.Controllers;

namespace Tests.Tests
{
    class MarcasTests
    {
        [Test]
        public void ComboMarcas()
        {
            MarcasController controller = new MarcasController();
            PartialViewResult result = controller.ComboMarcas() as PartialViewResult;
            Assert.IsNotNull(result);
        }
    }
}

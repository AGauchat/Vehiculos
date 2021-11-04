using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vehiculos.Models.Views
{
    public class VehiculosView
    {
        public long Id { get; set; }
        public string Patente { get; set; }
        public long IDMarca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Dueño { get; set; }
        public int Puertas { get; set; }
    }
}
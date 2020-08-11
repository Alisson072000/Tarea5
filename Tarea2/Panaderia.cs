using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tarea2
{
    class Panaderia
    {
        public int PanaderiaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public List<ProductoPanaderia> ProductoPanaderia { get; set; } = new List<ProductoPanaderia>();
        
        
        public string Informacion()
        {
            return $"La Panaderia {Nombre}" +
                $" esta ubicada {Direccion} puedes contactarnos {Telefono} ";
        }
        public string Producir()
        {
            return $"La Panaderia {Nombre} produce varios tipos de panes semanales\n";
        }
        public string Producir(string parametro)
        {
            return $"La Panaderia {Nombre} produce varios tipos de panes mensuales\n";
        }
        

    }
}

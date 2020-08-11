using System.Collections.Generic;

namespace Tarea2
{
    class Producto
    {

        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public float Calorias { get; set; }
        public Panaderia PanaderiaProductos { get; set; }
        public List<ProductoPanaderia> ProductoPanaderia { get; set; } = new List<ProductoPanaderia>();
        public string Informacion()
        {
            return $"El producto {Nombre} contiene {Calorias} esta elaborado con {Ingredientes} ";
        }

    }
    
    
}


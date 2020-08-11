using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea2
{
    class ProductoPanaderia
    {
        [ForeignKey(name: "Panaderia")]
        public int PanaderiaId { get; set; }
        public Panaderia Panaderia { get; set; }
        [ForeignKey(name: "Producto")]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

    }
}

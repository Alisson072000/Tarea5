using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace Tarea2
{
    class Cargo
    {
        public int CargoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Empleado Encargado { get; set; }
        
    }
}

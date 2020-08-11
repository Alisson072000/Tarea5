using System.Collections.Generic;

namespace Tarea2
{
    class Empleado :Persona
    {
        public Panaderia Trabaja { get; set; }
        private Cargo funcion;
        public Cargo Funcion
        {
            get { return funcion; }
            set { funcion = value;
                funcion.Encargado = this;
            }
            
        }

        public string Saludar()
        {
            return $"Bienvenido a la casa de la delicia del Pan\n ";

        }
        public string Informacion()
        {
            return $"La personan encargada de antenderle es mi persona {Nombre} {Apellido} \n ";
        }
        public string Atender()
        {
            return $"Que producto de nuestra panaderia desea'\n";

        }
        public Empleado():base()
        {
                
        }
    }
    
}

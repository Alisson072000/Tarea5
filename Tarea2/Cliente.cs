namespace Tarea2
{
    class Cliente:Persona
    {
        public Producto Preferencia{ get;set; }

        public string Saludar()
        {
            return $" Buenos días\n ";
        }
        public string Informacion()
        {
            return $"Mi nombre es {Nombre} {Apellido} vivo en {Direccion}\n ";
        }
        public string productoPreferencia()
        {
            return $"Mi pan de preferencia es {Preferencia.Nombre}\n";
        }
        public Cliente():base() 
        {
            Nombre = "Steven ";
            Apellido = "Rocha";
            Telefono = "0991415679";
        }
        public new string Caminar()
        {
            return $"El cliente {this.Nombre} {base.Caminar()} ";
        } 
    }
}

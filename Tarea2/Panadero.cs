namespace Tarea2
{
    public class Panadero : Persona 
    {
        public string Hornear(string tipoPan)
        {
            return $"Estoy horneando  {tipoPan}";
        }
        public string Preparar(string tipoIngredientes)
        {
            return $"Estoy preparando {tipoIngredientes} con los ingredientes";
        }
        public string Elaborar(string tiposPanes)
        {
            return $"Yo elaboro varios diseños de panes como {tiposPanes}";
        }

    }
}
